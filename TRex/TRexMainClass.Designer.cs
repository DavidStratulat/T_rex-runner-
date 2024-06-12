namespace TRex {
    partial class TRexMainClass {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOverlabel = new System.Windows.Forms.Label();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trexPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScoreLabel
            // 
            this.txtScoreLabel.AutoSize = true;
            this.txtScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreLabel.Location = new System.Drawing.Point(13, 13);
            this.txtScoreLabel.Name = "txtScoreLabel";
            this.txtScoreLabel.Size = new System.Drawing.Size(34, 24);
            this.txtScoreLabel.TabIndex = 4;
            this.txtScoreLabel.Text = "  ";
            this.txtScoreLabel.Click += new System.EventHandler(this.txtScoreLabel_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 12;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // GameOverlabel
            // 
            this.GameOverlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverlabel.Location = new System.Drawing.Point(140, 90);
            this.GameOverlabel.Name = "GameOverlabel";
            this.GameOverlabel.Size = new System.Drawing.Size(501, 83);
            this.GameOverlabel.TabIndex = 6;
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.Image = global::TRex.Properties.Resources.Screenshot_2024_06_07_183500;
            this.ResetPictureBox.Location = new System.Drawing.Point(304, 187);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(141, 117);
            this.ResetPictureBox.TabIndex = 5;
            this.ResetPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TRex.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(564, 373);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TRex.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(354, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // trexPictureBox
            // 
            this.trexPictureBox.Image = global::TRex.Properties.Resources.running;
            this.trexPictureBox.Location = new System.Drawing.Point(125, 358);
            this.trexPictureBox.Name = "trexPictureBox";
            this.trexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.trexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trexPictureBox.TabIndex = 1;
            this.trexPictureBox.TabStop = false;
            // 
            // TRexMainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameOverlabel);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.txtScoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trexPictureBox);
            this.Name = "TRexMainClass";
            this.Text = "X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trexPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.Label GameOverlabel;
    }
}

