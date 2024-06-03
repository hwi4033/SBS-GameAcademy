using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sokoban
{
    internal class Stages
    {
        public int[,] stage1 = new int[7, 7] {
                {0,0,1,1,1,1,0 },
                {0,0,1,0,0,1,0 },
                {1,1,1,0,0,1,0 },
                {1,0,2,0,0,1,1 },
                {1,2,0,0,0,0,1 },
                {1,1,1,0,0,0,1 },
                {0,0,1,1,1,1,1 }
            };
        public int[,] stage2 = new int[9, 9] {
            {1,1,1,1,1,0,0,0,0 },
            {1,0,0,0,1,0,0,0,0 },
            {1,0,3,3,1,0,1,1,1 },
            {1,0,3,0,1,0,1,2,1 },
            {1,1,1,0,1,1,1,2,1 },
            {0,1,1,0,0,0,0,2,1 },
            {0,1,0,0,0,1,0,0,1 },
            {0,1,0,0,0,1,1,1,1 },
            {0,1,1,1,1,1,0,0,0 }
        };

        public void Rendering(int[,] stage)
        {
            for (int i = 0; i < stage.GetLength(0); i++)
            {
                for (int j = 0; j < stage.GetLength(1); j++)
                {
                    if (stage[i, j] == 0) Console.Write("  ");
                    else if (stage[i, j] == 1) Console.Write("▩");
                    else if (stage[i, j] == 2) Console.Write("⊙");
                }
                Console.WriteLine();
            }
        }
    }
}
