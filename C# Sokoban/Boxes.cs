using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sokoban
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
        public Boxes(Boxes boxes)
        {
            x = new int();
            y = new int();
            shape = boxes.shape;
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

        public void BoxMove(int[,] stage, int px, int py)
        {
            
        }
    }
}
