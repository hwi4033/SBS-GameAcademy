using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Screen
    {
        public void Rendering(int[,] stage)
        {
            for (int i = 0; i < stage.GetLength(0); i++)
            {
                for (int j = 0; j < stage.GetLength(1); j++)
                {
                    if (stage[i, j] == 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}