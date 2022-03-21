using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_46337z_MyProject
{
    public partial class Form1 : Form
    {

        bool isGameOver;

        bool goRight;
        bool goLeft;
        
        int speed;

        int ballx;
        int bally;

        int score;

        private Random random = new Random();
        
        PictureBox[] blockArray;
        public Form1()
        {
            InitializeComponent();

            PlaceBlocks();
        }

        private void setupGame()
        {
            isGameOver = false;
            score = 0;
            speed = 15;
            ballx = 5;
            bally = 5;
            label1.Text = "Score: " + score;

            ball.Left = 376;
            ball.Top = 434;
            player.Left = 347;

            gameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "block")
                {
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    x.BackColor = randomColor;
                }
            }
        }
        private void PlaceBlocks()

        {
            blockArray = new PictureBox[35];

            int a = 0;

            int top = 50;
            int left = 100;

            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "block";
                blockArray[i].BackColor = Color.White;


                if (a == 5)
                {
                    top += 50;
                    left = 100;
                    a = 0;
                }

                if (a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 130;
                }

            }
            setupGame();
        }

        private void removeBlocks()
        {
            foreach (PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }
        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left < 700)
            {
                player.Left += speed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 775)
            {
                ballx = -ballx;
            }
            if (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {

                ball.Top = 463;

                bally = random.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = random.Next(5, 12) * -1;
                }
                else
                {
                    ballx = random.Next(5, 12);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        this.Controls.Remove(x);
                    }
                }

            }


            if (score == 35)
            {
                gameOver("You Win!! Press Enter to Play Again");
            }

            if (ball.Top > 580)
            {
                gameOver("You Lose!! Press Enter to try again");
            }

        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                PlaceBlocks();
            }
        }
        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();
            label1.Text = "Score: " + score + " " + message;
        }

    }
}
