using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRex {
    public partial class Form1 : Form {
        // aceste proprietati sunt private. De ce ele sunt private?
        bool jumping = false;
        bool isGameOver = false;
        Random random = new Random();
        int jumpSpeed = 12;
        int forceKeyPressed = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position = 0;

        public Form1() {
            InitializeComponent();
            GameReset();

        }

        private void GameReset() {
            
        }

        private void MainGameTimerEvent(object sender, EventArgs e) {

        }

        private void KeyIsDownEvent(object sender, KeyEventArgs e) {

        }

        private void KeyIsUpEvent(object sender, KeyEventArgs e) {

        }
    }
}
