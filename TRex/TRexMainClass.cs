using System;
using System.Windows.Forms;

namespace TRex {
    public partial class TRexMainClass : Form {
        // aceste proprietati sunt private. De ce ele sunt private?
        bool jumping = false; // boolean to check if player is jumping or not
        bool isGameOver = false;
        Random random = new Random(); //  used to calculate a random location for the obstacles to spawn once the game starts and when the reach the fast left of the screen.
        int jumpSpeed; // integer to set jump speed
        int force = 20; // integer called force will be used to figure out how faster the T Rex jumps up and how high he can do before coming down.
        int score = 0; // Each time a obstacles leaves the form successfully without hitting the player it 1 will be added to this integer.
        int obstacleSpeed = 5; //  used to animate the obstacles. This will pull the obstacles towards the left of the screen towards the player.
        int position = 0;
        int i = 1;
        public TRexMainClass() { // constructor sau c-tor (functie sau metoda)
            InitializeComponent(); // initializeaza componentele grafice 
            GameReset();
        }

        private void GameReset() {
            
            jumping = false;                   
            force = 20;
            score = 0;
            jumpSpeed = 0;
            obstacleSpeed = 6;
            txtScoreLabel.Text = "Score" + score;
            trexPictureBox.Image = Properties.Resources.running;
            isGameOver = false;
            i = 1;
            GameOverlabel.Text = "";
            ResetPictureBox.Image = Properties.Resources.Screenshot_2024_06_07_183500;

            foreach (Control x in this.Controls) {
                if (x is PictureBox && (string)x.Tag == "obstacle") {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 25);
                    x.Left = position;

                }

            }

            gameTimer.Start();
        }

        private void MainGameTimerEvent(object sender, EventArgs e) {
           // trexPictureBox.Top += jumpSpeed;  
            trexPictureBox.Top = trexPictureBox.Top + jumpSpeed;

            txtScoreLabel.Text = "Score: " + score;

            if (jumping == true && force < 0) {
                  jumping = false;
            }
            
            if (jumping == true) {
                jumpSpeed = -8 ;
                force -- ;
            } else {
                jumpSpeed = 8;
            }


            if (trexPictureBox.Top > 366 && jumping == false) {
                force = 15;
                trexPictureBox.Top = 367;
                jumpSpeed = 0;
            }


            foreach (Control x in this.Controls) {
                if (x is PictureBox && (string)x.Tag == "obstacle") {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100) {
                        x.Left = this.ClientSize.Width + random.Next(200, 500) + (x.Width * 25);
                        score++;
                    }

                    if (trexPictureBox.Bounds.IntersectsWith(x.Bounds)) {
                        gameTimer.Stop();
                        trexPictureBox.Image = Properties.Resources.dead;
                        txtScoreLabel.Text += " Press R to restart the game!";
                        isGameOver = true;
                        ResetPictureBox.Image = Properties.Resources.Screenshot_2024_06_07_182522;
                        GameOverlabel.Text = "Game Over";
                    }
                }
            }
            if (score == 5*i) {
                obstacleSpeed = obstacleSpeed+1;
                i++;
            }
             
        }

        private void KeyIsDownEvent(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space && jumping == false) {
                jumping = true;
            }
        }

        private void KeyIsUpEvent(object sender, KeyEventArgs e) {
            if (jumping == true) {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true) {
                GameReset();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void txtScoreLabel_Click(object sender, EventArgs e)
        {
        
        }
    }
}
