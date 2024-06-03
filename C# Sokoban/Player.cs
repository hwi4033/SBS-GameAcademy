using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sokoban
{
    internal class Player
    {
        private int x;
        private int y;
        private string shape;
        static int direction;

        public Player(int x, int y, string shape)
        {
            this.x = x;
            this.y = y;
            this.shape = shape;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        public int Move(int [,] stage, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (stage[y - 1, x / 2] != 1) y--;
                    direction = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    if (stage[y, x / 2 - 1] != 1) x -= 2;
                    direction = 2;
                    break;
                case ConsoleKey.RightArrow:
                    if (stage[y, x / 2 + 1] != 1) x += 2;
                    direction = 3;
                    break;
                case ConsoleKey.DownArrow:
                    if (stage[y + 1, x / 2] != 1) y++;
                    direction = 4;
                    break;
            }
            return direction;
        }
    }
}
