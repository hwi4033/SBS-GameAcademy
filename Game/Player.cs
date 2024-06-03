using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        private int x;
        private int y;
        private string shape;
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
        public void Move(int[,] map, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[y - 1, x / 2] == 0 || map[y - 1, x / 2] == 2) y--;
                    else if (map[y - 1, x / 2] == 3)
                    {
                        if (map[y - 2, x / 2] == 0)
                        {
                            map[y - 1, x / 2] = 0;
                            map[y - 2, x / 2] = 3;
                            y--;
                        }
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[y, x / 2 - 1] == 0 || map[y, x / 2 - 1] == 2) x -= 2;
                    else if (map[y, x / 2 - 1] == 3)
                    {
                        if (map[y, x / 2 - 2] == 0 || map[y, x / 2 - 2] == 2)
                        {
                            map[y, x / 2 - 1] = 0;
                            map[y, x / 2 - 2] = 3;
                            x -= 2;
                        }
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[y, x / 2 + 1] != 1) x += 2;
                    break;
                case ConsoleKey.DownArrow:
                    if (map[y + 1, x / 2] != 1) y++;
                    break;
            }
        }
    }
}
