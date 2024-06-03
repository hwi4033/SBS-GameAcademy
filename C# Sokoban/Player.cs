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

        public void Move(int [,] stage, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (stage[y - 1, x / 2] != 1)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (stage[y, x / 2 - 1] != 1)
                    {
                        x -= 2;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (stage[y, x / 2 + 1] != 1)
                    {
                        x += 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (stage[y + 1, x / 2] != 1)
                    {
                        y++;
                    }
                    break;
            }
        }
        public void Collider(int[,] stage, int bx, int by)
        {
            if (stage[y - 1, x / 2] == stage[by, bx / 2])
            {
                if (stage[by - 1, bx / 2] != 1)
                {

                }
            }
        }
    }
}
