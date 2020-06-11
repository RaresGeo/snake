using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Directions
    {
        Up,
        Down, 
        Left, 
        Right
    };
    class level
    {
        public static int cellWidth { get; set; }
        public static int cellHeight { get; set; }
        public static int score { get; set; }
        public static int snakeSpeed { get; set; }
        public static bool gameOver { get; set; }
        public static Directions dir { get; set; }

        public level()
        {
            cellWidth = 32;
            cellHeight = 32;
            score = 0;
            snakeSpeed = 32;
            gameOver = false;
            dir = Directions.Down;
        }
    }
}
