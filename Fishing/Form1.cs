using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fishing
{
    public partial class Form1 : Form
    {
        private bool lose = false;
        private int countFish = 0;
        private int countLife = 3;
        private int speed = 5;
        private int s = 10;
        private bool t = true;


        public Form1()
        {
            InitializeComponent();

            labellose.Visible = false;
            buttonStart.Visible = false;
            KeyPreview = true;
            timer1.Enabled = false;
            timer1.Interval = 1000;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            frog1.Top += speed;
            frog2.Top += speed;
            fish.Top += speed;
            bigFish.Top += speed;
            seaweed1.Top += speed;

            GetCoordinate(-600, fish);
            GetCoordinate(-600, bigFish);
            GetCoordinate(-400, seaweed1);
            GetCoordinate(-130, frog1);
            GetCoordinate(-400, frog2);
            
            GetCoordinateIfIntersects(frog1, -600, false);
            GetCoordinateIfIntersects(frog2, -600, false);
            GetCoordinateIfIntersects(fish, -50, true);
            GetCoordinateIfIntersects(seaweed1, -1200, false);
            GetCoordinateIfIntersects(bigFish, -600, true);

            if (countLife == 0)
            {
                timer.Enabled = false;
                labellose.Visible = true;
                buttonStart.Visible = true;
                lose = true;
            }
        }

        private void GetCoordinateIfIntersects(PictureBox name, int topCoordinate, bool isFish)
        {
            if (player.Bounds.IntersectsWith(name.Bounds))
            {
                if (isFish)
                {
                    countFish++;
                    labelfish.Text = "Рыбки: " + countFish.ToString();
                }
                else
                {
                    countLife--;
                    labelLife.Text = "Жизни: " + countLife.ToString();
                }
                name.Top = topCoordinate;
                Random rand = new Random();
                name.Left = rand.Next(0, 400);
            }
        }

        public void GetCoordinate(int topCoordinate, PictureBox name)
        {
            if (name.Top >= 600)
            {
                name.Top = topCoordinate;
                Random rand = new Random();
                name.Left = rand.Next(0, 400);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speed = 5;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 0)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 600)
                player.Left += speed;
        }

        private void buttonRestorationHeart_Click(object sender, EventArgs e)
        {
            if (t)
            {
                timer1.Start();
                speed = 10;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            label1.Text = s.ToString();
            if (s <= 0)
            {
                speed = 5;
                t = false;
                countLife++;
                labelLife.Text = "Жизни: " + countLife.ToString();
                timer1.Stop();
            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            frog1.Top = -130;
            frog2.Top = -400;
            s = 10;
            t = true;
            label1.Text = s.ToString();
            labellose.Visible = false;
            buttonStart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countFish = 0;
            countLife = 3;
            labelfish.Text = "Рыбки: 0";
            labelLife.Text = "Жизни: 3";
            fish.Top = -550;
        }
    }
}
