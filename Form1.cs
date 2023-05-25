using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Space_Shoter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer Shoot = new WindowsMediaPlayer();
        WindowsMediaPlayer explotion = new WindowsMediaPlayer();
        WindowsMediaPlayer gameOverSound = new WindowsMediaPlayer();
        WindowsMediaPlayer monsterKill = new WindowsMediaPlayer();
        WindowsMediaPlayer rampage = new WindowsMediaPlayer();




        bool goLeft, goRight, goUp, goDown, shooting, isGameOver;
        int score;
        int playerSpeed = 9;
        int enemySpeed;
        int bulletSpeed = 25;
        Random rnd = new Random();
        private System.Windows.Forms.PictureBox enemyBullet;
        bool enemyShooting = false;
        public Form1()
        {
            InitializeComponent();
            initGameExtras();
            resetGame();
        }

        public void initGameExtras()
        {
            this.enemyBullet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBullet)).BeginInit();
            this.enemyBullet.Image = global::Space_Shoter.Properties.Resources.bullet;
            this.enemyBullet.BackColor = System.Drawing.Color.Transparent;
            this.enemyBullet.Location = new System.Drawing.Point(350, 321);
            this.enemyBullet.Name = "bullet";
            this.enemyBullet.Size = new System.Drawing.Size(7, 27);
            this.enemyBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyBullet.TabIndex = 0;
            this.enemyBullet.TabStop = false;
            this.enemyBullet.Visible = true;
            this.Controls.Add(this.enemyBullet);
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.enemyBullet.BringToFront();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = score.ToString();

            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;


            if(enemyOne.Top > 650 || enemyTwo.Top > 650 || enemyThree.Top >650)
            {
                gameOver();
            }

            if (!enemyShooting)
            {
                Random random = new Random();
                if (random.Next(1, 100) <= 5)
                {
                    enemyShooting = true;
                    enemyBullet.Visible = true;
                    var en = random.Next(0, 2);
                    PictureBox[] list = { enemyOne, enemyTwo, enemyThree };
                    if ((list[en].Bottom > 0) && (list[en].Bottom < this.Height / 2))
                    {
                        enemyBullet.Top = list[en].Bottom + 30;
                        enemyBullet.Left = list[en].Left + list[en].Width / 2;
                    } else
                    {
                        enemyShooting = false;
                    }

                    /*switch (en)
                    {
                        case 1:
                            enemyBullet.Top = enemyOne.Bottom + 30;
                            enemyBullet.Left = enemyOne.Left + enemyOne.Width / 2;
                            break;
                        case 2:
                            enemyBullet.Top = enemyTwo.Bottom + 30;
                            enemyBullet.Left = enemyTwo.Left + enemyThree.Width / 2;
                            break;
                        case 3:
                            enemyBullet.Top = enemyThree.Bottom + 30;
                            enemyBullet.Left = enemyThree.Left + enemyThree.Width / 2;
                            break;
                    }*/

                }

            }

            if (enemyShooting)
            {
                enemyBullet.Top += bulletSpeed / 2;
                if (enemyBullet.Bounds.IntersectsWith(player.Bounds))//when a object bounds with another
                {
                    explotion.URL = @"sounds\boom.mp3";

                    gameOver();
                }
                if (enemyBullet.Top > this.Bottom)
                {
                    enemyShooting = false;
                    enemyBullet.Left = -300;
                    enemyBullet.Visible = false;
                }
            }

            //player movment logic starts

            if(goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if(goRight == true && player.Left < 700)
            {
                player.Left += playerSpeed;
            }
            if(goUp == true && player.Top > 0) 
            { 
                player.Top -= playerSpeed; 
            }
            if (goDown == true && player.Top < 560)
            {
                player.Top += playerSpeed;
            }

            //player movment logic ends
            //bullet logic starts
            if (shooting == true)
            {
                //bulletSpeed = 25;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                //bulletSpeed = 0;
            }
            if(bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))//when a object bounds with another
            {
                explotion.URL = @"sounds\\boom.mp3";
                score += 1;//score will increas by 1
                enemyOne.Top = -450;//we reset the enemy to come again
                enemyOne.Left = rnd.Next(20, 600);//we give him a random so he dosnt spown the same
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                explotion.URL = @"sounds\boom.mp3";
                score += 1;
                enemyTwo.Top = -700; //this one spowns more behaind
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                explotion.URL = @"sounds\boom.mp3";
                score += 1;
                enemyThree.Top = -800;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (player.Bounds.IntersectsWith(enemyThree.Bounds)||
                player.Bounds.IntersectsWith(enemyTwo.Bounds)||
                enemyTwo.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                gameOver();
            }
            //Game SPEED UP
            if (score == 5)
            {
                monsterKill.URL = @"sounds\Monster Kill.mp3";
                playerSpeed = 12;
                enemySpeed = 6;
                txtScore.Text += Environment.NewLine + "MONSTER KILL!!!";
            }
            if(score == 10)
            {
                rampage.URL = @"sounds\Rampage.mp3";
                playerSpeed = 15;
                enemySpeed = 8;
                txtScore.Text += Environment.NewLine + "RAMPAGE!!!";
            }
            if (score >= 15 )
            {
                txtScore.Text = score.ToString();
                youWin();
                this.txtScore.BringToFront();
            }


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }
        //what happens when you reles a key
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)//shooting logic
            {
                shooting = true;
                Shoot.URL = @"sounds\shoot.mp3";

                bullet.Top = player.Top + 30;//bullet spowns from spaceShip
                bullet.Left = player.Left + (player.Width /2 ) -(bullet.Width /2);

            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
                this.txtScore.SendToBack();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 3;
            playerSpeed = 9;

            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;//gives a spown point out of the form
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0,900) * -1;

            score = 0;
            bulletSpeed = 25;
            bullet.Left = -300;
            enemyBullet.Left = -300;
            shooting = false;

            txtScore.Text = score.ToString();

        }

        private void gameOver()
        {
            isGameOver = true;
            gameOverSound.URL = @"sounds\Game Over.mp3";

            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "Game Over!!!" + Environment.NewLine + "Press Enter to try again.";
            if (isGameOver)
            {
                this.txtScore.BringToFront();
            }

        }

        private void youWin()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "you WON!!!" + Environment.NewLine + "Press Enter to Restart.";
        }
    }
}
