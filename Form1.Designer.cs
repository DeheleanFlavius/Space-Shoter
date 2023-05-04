using System.Reflection.Emit;
using System.Threading;

namespace Space_Shoter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.ForeColor = System.Drawing.Color.Red;
            this.txtScore.Location = new System.Drawing.Point(0, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(800, 700);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::Space_Shoter.Properties.Resources.munition;
            this.bullet.Location = new System.Drawing.Point(420, 268);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(30, 30);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 0;
            this.bullet.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Space_Shoter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(304, 559);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 90);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Transparent;
            this.enemyThree.Image = global::Space_Shoter.Properties.Resources.enemyThree;
            this.enemyThree.Location = new System.Drawing.Point(564, 82);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(90, 90);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemyThree.TabIndex = 0;
            this.enemyThree.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.enemyTwo.Image = global::Space_Shoter.Properties.Resources.enemyTwo;
            this.enemyTwo.Location = new System.Drawing.Point(304, 82);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(90, 90);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemyTwo.TabIndex = 0;
            this.enemyTwo.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.Image = global::Space_Shoter.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(87, 82);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(90, 90);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.txtScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "Form1";
            this.Text = "Space Force";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

