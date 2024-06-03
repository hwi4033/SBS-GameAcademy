using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sokoban
{
    internal class Screen
    {
        private readonly int width;
        private readonly int height;

        public Screen()
        {   
            width = 40;
            height = 20;

            Console.SetWindowSize(width, height);
        }
    }
}
