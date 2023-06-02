using System;

namespace PingPong
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        #region Variable 
        const int ident = 7;
        int ballSize = 50;
        Size platformSize = new Size(33, 212);
        int directionX = 16;
        int directionY = 14;
        bool platformMoveUp = false;
        bool platformMoveDown = false;
        int platformSpeed = 13;
        int scoreLeft = 0;
        int scoreRight = 0;
        int scoretimeout = 0;



        #endregion
        #region Init
        void Init()
        {
            ball.Size = new Size(ballSize, ballSize);
            myPlatform.Size = platformSize;
            platformOpponent.Size = platformSize;
            myPlatform.Left = ident;
            platformOpponent.Left = gameField.Width - platformSize.Width - ident;
            tableGameScore.Left = gameField.Width / 2 - platformSize.Width / 2;

        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            Init();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        #endregion
        #region MoveBall
        private void MoveBall()
        {
            //TestBlockEasy();
            TestBlock();



            if (IsWallY(ball.Top))
            {
                directionY *= -1;
            }

            if (IsWallX(ball.Left))
            {
                directionX *= -1;


            }

            ball.Left += directionX;
            ball.Top += directionY;

        }

        void TestBlockEasy()
        {
            if (ball.Bounds.IntersectsWith(platformOpponent.Bounds))
            {
                directionX = Math.Abs(directionX) * -1;
            }
            if (ball.Bounds.IntersectsWith(myPlatform.Bounds))
            {
                directionX = Math.Abs(directionX);
            }

        }

        void GenerateBlocks()
        {
            int blocks = rand.Next(0, 3) + 1;
            for (int i = 0; i < blocks; i++)
            {
                int border = ballSize * 7;
                int x = rand.Next(border, gameField.Width - border);
                int y = rand.Next(border, gameField.Height - border);

                PictureBox block = new PictureBox();
                block.Width = rand.Next(50, 350);
                block.Height = rand.Next(50, 350);
                block.Location = new Point(x, y);
                block.Image = Properties.Resources.chees;

                gameField.Controls.Add(block);
            }
        }

        void TestBlock()
        {
            foreach (Control element in gameField.Controls)
                if (element is PictureBox)
                {
                    if (BlockIntersectY(element) || BlockIntersectX(element))
                    {
                        if (element != myPlatform && element != platformOpponent)
                        {
                            gameField.Controls.Remove(element);
                        }
                    }

                }



        }

        bool BlockIntersectY(Control element)
        {
            Rectangle ballRectangle = ball.Bounds;

            Rectangle intersectionY = Rectangle.Intersect(ballRectangle, element.Bounds);
            if (!intersectionY.IsEmpty)
            {
                if (intersectionY.Height < ballSize / 2)
                {
                    if (ballRectangle.Top == intersectionY.Top)
                    {
                        ball.Top += intersectionY.Height + 1;
                        directionY = Math.Abs(directionY);
                        return true;
                    }
                    else if (ballRectangle.Bottom == intersectionY.Bottom)
                    {
                        ball.Top -= intersectionY.Height + 1;
                        directionY = Math.Abs(directionY) * -1;
                        return true;
                    }
                }
            }
            return false;
        }

        bool BlockIntersectX(Control element)
        {
            Rectangle ballRectangle = ball.Bounds;

            Rectangle intersectionX = Rectangle.Intersect(ballRectangle, element.Bounds);
            if (!intersectionX.IsEmpty)
            {
                if (intersectionX.Width < ballSize / 2)
                {
                    if (ballRectangle.Left == intersectionX.Left)
                    {
                        ball.Left += intersectionX.Width + 1;
                        directionX = Math.Abs(directionX);
                        return true;
                    }
                    else if (ballRectangle.Right == intersectionX.Right)
                    {
                        ball.Left -= intersectionX.Width + 1;
                        directionX = Math.Abs(directionX) * -1;
                        return true;
                    }
                }
            }
            return false;
        }


        bool IsWallY(int y)
        {
            if (y < 0 || y > gameField.Height - ballSize)
            {

                return true;
            }
            return false;

        }

        bool IsWallX(int x)
        {
            if (x < 0 || x > gameField.Width - ballSize)
            {
                if (x < 0)
                {
                    scoreRight++;
                    scorelabelRight.ForeColor = Color.Red;
                    leftLine.Visible = true;
                }
                else
                {
                    scoreLeft++;
                    scorelabelLeft.ForeColor = Color.Turquoise;

                    rightLine.Visible = true;

                }
                scoretimeout = 30;
                scorelabelLeft.Text = scoreLeft.ToString();
                scorelabelRight.Text = scoreRight.ToString();
                GenerateBlocks();
                return true;
            }
            return false;
        }



        #endregion
        #region MoveMyOpponent
        void MovePlatformOpponent()
        {
            int reaction = platformSize.Height / 3;
            int ballCenter = ball.Top + ballSize / 2;
            int platformCenter = platformOpponent.Top + platformSize.Height / 2;
            if (Math.Abs(ballCenter - platformCenter) > reaction)
            {
                platformOpponent.Top = platformOpponent.Top + (int)((ballCenter - platformCenter) * 0.12);
            }
        }


        #endregion
        #region MoveMyPlatform 


        void MovePlatformGamer()
        {
            if (platformMoveUp)
            {
                myPlatform.Top -= platformSpeed;
            }
            else if (platformMoveDown)
            {
                myPlatform.Top += platformSpeed;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                platformMoveUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                platformMoveDown = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                platformMoveUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                platformMoveDown = false;
            }
        }
        #endregion




        void UpdateScore()
        {
            if (scoretimeout >= 0)
            {
                if (scoretimeout == 0)
                {
                    scorelabelLeft.ForeColor = Color.Black;
                    scorelabelRight.ForeColor = Color.Black;
                    leftLine.Visible = false;
                    rightLine.Visible = false;
                }
                scoretimeout--;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveBall();
            MovePlatformOpponent();
            MovePlatformGamer();
            UpdateScore();
        }


    }
}