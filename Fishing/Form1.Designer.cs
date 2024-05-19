namespace Fishing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.frog1 = new System.Windows.Forms.PictureBox();
            this.frog2 = new System.Windows.Forms.PictureBox();
            this.labellose = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.fish = new System.Windows.Forms.PictureBox();
            this.bigFish = new System.Windows.Forms.PictureBox();
            this.labelfish = new System.Windows.Forms.Label();
            this.seaweed1 = new System.Windows.Forms.PictureBox();
            this.labelLife = new System.Windows.Forms.Label();
            this.buttonRestorationHeart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaweed1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(296, 454);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(148, 146);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.WaitOnLoad = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frog1
            // 
            this.frog1.BackColor = System.Drawing.Color.Transparent;
            this.frog1.Image = ((System.Drawing.Image)(resources.GetObject("frog1.Image")));
            this.frog1.Location = new System.Drawing.Point(130, -135);
            this.frog1.Name = "frog1";
            this.frog1.Size = new System.Drawing.Size(49, 42);
            this.frog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog1.TabIndex = 3;
            this.frog1.TabStop = false;
            // 
            // frog2
            // 
            this.frog2.BackColor = System.Drawing.Color.Transparent;
            this.frog2.Image = ((System.Drawing.Image)(resources.GetObject("frog2.Image")));
            this.frog2.Location = new System.Drawing.Point(564, -300);
            this.frog2.Name = "frog2";
            this.frog2.Size = new System.Drawing.Size(48, 37);
            this.frog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog2.TabIndex = 4;
            this.frog2.TabStop = false;
            // 
            // labellose
            // 
            this.labellose.AutoSize = true;
            this.labellose.BackColor = System.Drawing.Color.Red;
            this.labellose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellose.Location = new System.Drawing.Point(216, 126);
            this.labellose.Name = "labellose";
            this.labellose.Size = new System.Drawing.Size(314, 51);
            this.labellose.TabIndex = 5;
            this.labellose.Text = "Вы проиграли";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(198, 196);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(375, 74);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Начать новую игру";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // fish
            // 
            this.fish.BackColor = System.Drawing.Color.Transparent;
            this.fish.Image = ((System.Drawing.Image)(resources.GetObject("fish.Image")));
            this.fish.Location = new System.Drawing.Point(588, -130);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(73, 65);
            this.fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish.TabIndex = 7;
            this.fish.TabStop = false;
            // 
            // bigFish
            // 
            this.bigFish.BackColor = System.Drawing.Color.Transparent;
            this.bigFish.Image = ((System.Drawing.Image)(resources.GetObject("bigFish.Image")));
            this.bigFish.Location = new System.Drawing.Point(600, -600);
            this.bigFish.Margin = new System.Windows.Forms.Padding(0);
            this.bigFish.Name = "bigFish";
            this.bigFish.Size = new System.Drawing.Size(87, 73);
            this.bigFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bigFish.TabIndex = 9;
            this.bigFish.TabStop = false;
            // 
            // labelfish
            // 
            this.labelfish.AutoSize = true;
            this.labelfish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelfish.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfish.Location = new System.Drawing.Point(0, 0);
            this.labelfish.Name = "labelfish";
            this.labelfish.Size = new System.Drawing.Size(208, 51);
            this.labelfish.TabIndex = 10;
            this.labelfish.Text = "Рыбки: 0";
            // 
            // seaweed1
            // 
            this.seaweed1.BackColor = System.Drawing.Color.Transparent;
            this.seaweed1.Image = ((System.Drawing.Image)(resources.GetObject("seaweed1.Image")));
            this.seaweed1.Location = new System.Drawing.Point(370, -500);
            this.seaweed1.Name = "seaweed1";
            this.seaweed1.Size = new System.Drawing.Size(161, 141);
            this.seaweed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seaweed1.TabIndex = 11;
            this.seaweed1.TabStop = false;
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLife.Location = new System.Drawing.Point(0, 51);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(210, 51);
            this.labelLife.TabIndex = 12;
            this.labelLife.Text = "Жизни: 3";
            // 
            // buttonRestorationHeart
            // 
            this.buttonRestorationHeart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRestorationHeart.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRestorationHeart.CausesValidation = false;
            this.buttonRestorationHeart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestorationHeart.Location = new System.Drawing.Point(706, 1);
            this.buttonRestorationHeart.Name = "buttonRestorationHeart";
            this.buttonRestorationHeart.Size = new System.Drawing.Size(94, 50);
            this.buttonRestorationHeart.TabIndex = 14;
            this.buttonRestorationHeart.Text = "Увеличить жизни";
            this.buttonRestorationHeart.UseVisualStyleBackColor = false;
            this.buttonRestorationHeart.Click += new System.EventHandler(this.buttonRestorationHeart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(747, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRestorationHeart);
            this.Controls.Add(this.labelfish);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labellose);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.seaweed1);
            this.Controls.Add(this.bigFish);
            this.Controls.Add(this.fish);
            this.Controls.Add(this.frog2);
            this.Controls.Add(this.frog1);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaweed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox frog1;
        private System.Windows.Forms.PictureBox frog2;
        private System.Windows.Forms.Label labellose;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox fish;
        private System.Windows.Forms.PictureBox bigFish;
        private System.Windows.Forms.Label labelfish;
        private System.Windows.Forms.PictureBox seaweed1;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Button buttonRestorationHeart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

