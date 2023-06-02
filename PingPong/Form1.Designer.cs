namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameField = new Panel();
            rightLine = new Panel();
            leftLine = new Panel();
            platformOpponent = new PictureBox();
            myPlatform = new PictureBox();
            ball = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableGameScore = new TableLayoutPanel();
            scorelabelRight = new Label();
            scorelabelLeft = new Label();
            pictureBox1 = new PictureBox();
            gameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)platformOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myPlatform).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableGameScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameField
            // 
            gameField.BackColor = SystemColors.ActiveCaptionText;
            gameField.Controls.Add(pictureBox1);
            gameField.Controls.Add(rightLine);
            gameField.Controls.Add(leftLine);
            gameField.Controls.Add(platformOpponent);
            gameField.Controls.Add(myPlatform);
            gameField.Controls.Add(ball);
            gameField.Dock = DockStyle.Fill;
            gameField.Location = new Point(3, 35);
            gameField.Name = "gameField";
            gameField.Size = new Size(1310, 700);
            gameField.TabIndex = 0;
            // 
            // rightLine
            // 
            rightLine.BackColor = Color.Turquoise;
            rightLine.Dock = DockStyle.Right;
            rightLine.Location = new Point(1290, 0);
            rightLine.Name = "rightLine";
            rightLine.Size = new Size(20, 700);
            rightLine.TabIndex = 4;
            rightLine.Visible = false;
            // 
            // leftLine
            // 
            leftLine.BackColor = Color.Red;
            leftLine.Dock = DockStyle.Left;
            leftLine.Location = new Point(0, 0);
            leftLine.Name = "leftLine";
            leftLine.Size = new Size(20, 700);
            leftLine.TabIndex = 3;
            leftLine.Visible = false;
            // 
            // platformOpponent
            // 
            platformOpponent.BackgroundImage = Properties.Resources.Paddle2;
            platformOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            platformOpponent.Location = new Point(1263, 226);
            platformOpponent.Name = "platformOpponent";
            platformOpponent.Size = new Size(33, 212);
            platformOpponent.TabIndex = 2;
            platformOpponent.TabStop = false;
            // 
            // myPlatform
            // 
            myPlatform.BackgroundImage = Properties.Resources.Paddle1;
            myPlatform.BackgroundImageLayout = ImageLayout.Stretch;
            myPlatform.Location = new Point(12, 226);
            myPlatform.Name = "myPlatform";
            myPlatform.Size = new Size(33, 212);
            myPlatform.SizeMode = PictureBoxSizeMode.Zoom;
            myPlatform.TabIndex = 1;
            myPlatform.TabStop = false;
            // 
            // ball
            // 
            ball.BackgroundImage = Properties.Resources.Ball;
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.Enabled = false;
            ball.FlatStyle = FlatStyle.Flat;
            ball.Location = new Point(647, 307);
            ball.Name = "ball";
            ball.Size = new Size(50, 50);
            ball.TabIndex = 0;
            ball.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(gameField, 0, 1);
            tableLayoutPanel1.Controls.Add(tableGameScore, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.33604336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.6639557F));
            tableLayoutPanel1.Size = new Size(1316, 738);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableGameScore
            // 
            tableGameScore.Anchor = AnchorStyles.None;
            tableGameScore.ColumnCount = 2;
            tableGameScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGameScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableGameScore.Controls.Add(scorelabelRight, 1, 0);
            tableGameScore.Controls.Add(scorelabelLeft, 0, 0);
            tableGameScore.Location = new Point(533, 3);
            tableGameScore.Name = "tableGameScore";
            tableGameScore.RowCount = 1;
            tableGameScore.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableGameScore.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableGameScore.Size = new Size(250, 26);
            tableGameScore.TabIndex = 1;
            // 
            // scorelabelRight
            // 
            scorelabelRight.AutoSize = true;
            scorelabelRight.Dock = DockStyle.Fill;
            scorelabelRight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scorelabelRight.ForeColor = Color.Black;
            scorelabelRight.Location = new Point(128, 0);
            scorelabelRight.Name = "scorelabelRight";
            scorelabelRight.Size = new Size(119, 26);
            scorelabelRight.TabIndex = 1;
            scorelabelRight.Text = "0";
            scorelabelRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scorelabelLeft
            // 
            scorelabelLeft.AutoSize = true;
            scorelabelLeft.Dock = DockStyle.Fill;
            scorelabelLeft.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scorelabelLeft.ForeColor = Color.Black;
            scorelabelLeft.Location = new Point(3, 0);
            scorelabelLeft.Name = "scorelabelLeft";
            scorelabelLeft.Size = new Size(119, 26);
            scorelabelLeft.TabIndex = 0;
            scorelabelLeft.Text = "0";
            scorelabelLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ball;
            pictureBox1.Location = new Point(80, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 26);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 738);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "PingPong";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            Resize += Form1_Resize;
            gameField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)platformOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)myPlatform).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableGameScore.ResumeLayout(false);
            tableGameScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel gameField;
        private PictureBox platformOpponent;
        private PictureBox myPlatform;
        private Button ball;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel rightLine;
        private Panel leftLine;
        private TableLayoutPanel tableGameScore;
        private Label scorelabelRight;
        private Label scorelabelLeft;
        private PictureBox pictureBox1;
    }
}