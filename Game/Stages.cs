using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Stages
    {
        public int[,] stage1 = new int[7, 7] {
                {0,0,1,1,1,1,0 },
                {0,0,1,0,0,1,0 },
                {1,1,1,0,0,1,0 },
                {1,0,0,3,0,1,1 },
                {1,0,0,0,3,0,1 },
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
        
        public void Rendering(int[,] stages)
        {
            for (int i = 0; i < stages.GetLength(0); i++)
            {
                for (int j = 0; j < stages.GetLength(1); j++)
                {
                    if (stages[i, j] == 0) Console.Write("  ");
                    else if (stages[i, j] == 1) Console.Write("▩");    // 벽
                    else if (stages[i, j] == 2) Console.Write("⊙");
                    else if (stages[i, j] == 3) Console.Write("■");     // 박스 
                }
                Console.WriteLine();
            }
        }
        public void GoalRendering(int[,] stages)
        {
            if (stages == stage1)
            {
                if (stages[4, 3] != 3) stages[4, 3] = 2;
            }
        }
    }
}
