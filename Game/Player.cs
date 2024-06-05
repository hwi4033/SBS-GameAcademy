using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player : Boxes
    {
        private int px;
        private int py;
        private string pshape;
        private int moveCount = 0;

        public Player(int x, int y, string shape)
        {
            px = x;
            py = y;
            pshape = shape;
        }
        public int Px
        {
            get { return px; }
            set { px = value; }
        }
        public int Py
        {
            get { return py; }
            set { py = value; }
        }
        public string Pshape
        {
            get { return pshape; }
            set { pshape = value; }
        }
        public int MoveCount
        {
            get { return moveCount; }
            set { moveCount = value; }
        }

        public void Move(int[,] stage, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (stage[py - 1, px / 2] != 1 && stage[py - 1, px / 2] != stage[y, x / 2])
                    {
                        py--;
                        moveCount++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (stage[py, px / 2 - 1] != 1)
                    {
                        px -= 2;
                        moveCount++;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (stage[py, px / 2 + 1] != 1)
                    {
                        px += 2;
                        moveCount++;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (stage[py + 1, px / 2] != 1)
                    {
                        py++;
                        moveCount++;
                    }
                    break;
            }
        }
        public void Collider(int[,] stage, int bx, int by, ref int pushbox)
        {
            if (py - 1 == by && px / 2 == bx / 2)
            {
                if (stage[by - 1, bx / 2] == 1) pushbox = 0;
                else pushbox = 1;
            }
            else if (py == by && px / 2 - 1 == bx / 2)
            {
                if (stage[by, bx / 2 - 1] == 1) pushbox = 0;
                else pushbox = 2;
            }
            else if (py == by && px / 2 + 1 == bx / 2)
            {
                if (stage[by, bx / 2 + 1] == 1) pushbox = 0;
                else pushbox = 3;
            }
            else if (py + 1 == by && px / 2 == bx / 2)
            {
                if (stage[by + 1, bx / 2] == 1) pushbox = 0;
                else pushbox = 4;
            }
        }
    }
}