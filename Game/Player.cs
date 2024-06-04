﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
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

        public void Move(int[,] stage, Boxes[] boxes, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (!IsCollidingWithBox(boxes, x / 2, y - 1) && stage[y - 1, x / 2] != 1)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (!IsCollidingWithBox(boxes, x / 2 - 1, y) && stage[y, x / 2 - 1] != 1)
                    {
                        x -= 2;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (!IsCollidingWithBox(boxes, x / 2 + 1, y) && stage[y, x / 2 + 1] != 1)
                    {
                        x += 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (!IsCollidingWithBox(boxes, x / 2, y + 1) && stage[y + 1, x / 2] != 1)
                    {
                        y++;
                    }
                    break;
            }
        }

        private bool IsCollidingWithBox(Boxes[] boxes, int x, int y)
        {
            foreach (var box in boxes)
            {
                if (box.X / 2 == x && box.Y == y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}