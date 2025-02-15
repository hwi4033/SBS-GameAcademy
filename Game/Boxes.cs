﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Boxes
    {
        protected int x;
        protected int y;
        protected string shape;
        private int pushbox;

        public Boxes(int x, int y, string shape, int pushbox)
        {
            this.x = x;
            this.y = y;
            this.shape = shape;
            this.pushbox = pushbox;
        }
        public Boxes(Boxes boxes)
        {
            x = new int();
            y = new int();
            shape = boxes.shape;
            pushbox = new int();
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
        public int Pushbox
        {
            get { return pushbox; }
            set { pushbox = value; }
        }

        public void BoxMove(int[,] stage, int px, int py, int pushbox)
        {
            switch (pushbox)
            {
                case 1:
                    if (y == py && x / 2 == px / 2)
                    {
                        y--;
                    }
                    break;
                case 2:
                    if (y == py && x / 2 == px / 2)
                    {
                        x -= 2;
                    }
                    break;
                case 3:
                    if (y == py && x / 2 == px / 2)
                    {
                        x += 2;
                    }
                    break;
                case 4:
                    if (y == py && x / 2 == px / 2)
                    {
                        y++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}