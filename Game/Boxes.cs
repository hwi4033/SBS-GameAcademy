using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Boxes
    {
        private int x;
        private int y;
        private string shape;

        public Boxes(int x, int y, string shape)
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

        public void Move(int[,] stage, int playerX, int playerY, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (playerX == x / 2 && playerY == y + 1 && stage[y - 1, x / 2] != 1)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (playerY == y && playerX == x / 2 + 1 && stage[y, x / 2 - 1] != 1)
                    {
                        x -= 2;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (playerY == y && playerX == x / 2 - 1 && stage[y, x / 2 + 1] != 1)
                    {
                        x += 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (playerX == x / 2 && playerY == y - 1 && stage[y + 1, x / 2] != 1)
                    {
                        y++;
                    }
                    break;
            }
        }
    }
}