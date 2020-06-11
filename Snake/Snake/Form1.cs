using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<cell> Player = new List<cell>();
        private cell food = new cell();

        public Form1()
        {
            InitializeComponent();

            new level();

            delta.Interval = 1000 / level.snakeSpeed;
            delta.Tick += UpdateScreen();
            delta.Start();

            StartGame();

        }

        private void StartGame()
        {
            labelGameOver.Visible = false;
            new level();
            Player.Clear();

            cell head = new cell();

            head.x = pbArena.Size.Width / (level.cellWidth * 2);
            head.y = pbArena.Size.Height / (level.cellHeight * 2);
            Player.Add(head);

            labelScore.Text = level.score.ToString();
            generateFood();
        }

        private void generateFood()
        {
            int maxXPos = pbArena.Size.Width / level.cellWidth;
            int maxYPos = pbArena.Size.Height / level.cellHeight;

            Random rand = new Random();
            food = new cell();
            food.x = rand.Next(0, maxXPos);
            food.y = rand.Next(0, maxYPos);
        }

        private void updateScreen(object sender, EventArgs e)
        {
            if (level.gameOver == true)
            {
                if (playerInput.keyPressed(Keys.Enter))
                    StartGame();
            }
            else
            {
                if (playerInput.keyPressed(Keys.Right) && level.dir != Directions.Left)
                    level.dir = Directions.Right;

                if (playerInput.keyPressed(Keys.Left) && level.dir != Directions.Right)
                    level.dir = Directions.Left;

                if (playerInput.keyPressed(Keys.Up) && level.dir != Directions.Down)
                    level.dir = Directions.Up;

                if (playerInput.keyPressed(Keys.Down) && level.dir != Directions.Up)
                    level.dir = Directions.Down;
            }

            movePlayer();

            pbArena.Invalidate();
        }

        private void pbArena_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if(level.gameOver == false)
            {
                for(int i = 0; i < Player.Count; i++)
                {
                    canvas.FillRectangle(Brushes.White,
                        new Rectangle(Player[i].x * level.cellWidth,
                                      Player[i].y * level.cellHeight,
                                      level.cellWidth, level.cellHeight));

                    canvas.FillRectangle(Brushes.White,
                        new Rectangle(food.x * level.cellWidth,
                                      food.y * level.cellHeight,
                                      level.cellWidth, level.cellHeight));
                }

            }
            else
            {
                string gameOver = "Your final score is: " + level.score + "\nPress Enter to play again";
            }
        }

        private void MovePlayer()
        {
            for(int i = Snake.Count - 1; i > 0; i --)
                if
        }
    }
}
