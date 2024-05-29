using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Program
{
    class Screen
    {
        private readonly int width;
        private readonly int height;

        public Screen()
        {   // 콘솔 창의 사이즈 지정
            width = 100;
            height = 30;

            Console.SetWindowSize(width, height);
        }
    }

    class Character
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

        public void Move(int[,] maze, ConsoleKeyInfo key, ref bool state)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (maze[y - 1, x / 2] != 1) y--;
                    break;
                case ConsoleKey.LeftArrow:
                    if (maze[y, x / 2 - 1] != 1) x -= 2;
                    break;
                case ConsoleKey.RightArrow:
                    if (maze[y, x / 2 + 1] != 1) x += 2;
                    break;
                case ConsoleKey.DownArrow:
                    if (maze[y + 1, x / 2] != 1) y++;
                    break;
            }

            if (maze[y, x/2] == 2) state = false;
        }
    }

    class Bullet
    {
        private int[] damage = new int[10];

        public int this[int index]
        {
            get { return damage[index]; }
            set { damage[index] = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 좌표 이동 함수

            // Screen screen = new Screen();
            // ConsoleKeyInfo key;
            // 
            // int x = 4;
            // int y = 4;           
            // 
            // while (true)
            // {
            //     Console.SetCursorPosition(x, y);
            //     Console.WriteLine("★");
            //     
            //     key = Console.ReadKey(true);
            // 
            //     switch (key.Key)
            //     {
            //         case ConsoleKey.UpArrow:
            //             if(y > 0) y--;
            //             break;
            //         case ConsoleKey.LeftArrow:                       
            //             if(x > 0) x -= 2;
            //             break;
            //         case ConsoleKey.RightArrow:                        
            //             if(x < 98) x += 2;
            //             break;
            //         case ConsoleKey.DownArrow:                       
            //             if(y < 29) y++;
            //             break;
            //     }
            //     Console.Clear();
            // }

            #endregion

            #region 2차원 배열
            // 배열의 요소로 또 다른 배열을 가지는 배열입니다.

            // int i, j;
            // int[,] array2D = new int[3, 3] {
            //     { 1, 2, 3},
            //     { 4, 5, 6},
            //     { 7, 8, 9}
            // };            
            // 
            // for (i = 0; i < array2D.GetLength(0); i++)
            // {
            //     for (j = 0; j < array2D.GetLength(1); j++)
            //     {
            //         Console.Write(array2D[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // 2차원 배열은 행과 열로 구분되며, 앞에 있는 배열은 열을 의미하고, 뒤에 있는 배열은 행을 의미합니다.

            #endregion

            #region Maze Game
            // int[,] maze = new int[10,10] {
            //     { 1,1,1,1,1,1,1,1,2,1 },
            //     { 1,0,0,0,1,0,0,1,0,1 },
            //     { 1,0,1,1,1,0,1,1,0,1 },
            //     { 1,0,0,0,0,0,1,0,0,1 },
            //     { 1,0,1,1,1,0,1,1,0,1 },
            //     { 1,0,0,0,1,0,0,0,0,1 },
            //     { 1,0,1,1,1,0,1,1,1,1 },
            //     { 1,0,1,1,1,1,1,1,0,1 },
            //     { 1,0,0,0,0,0,0,0,0,1 },
            //     { 1,1,1,1,1,1,1,1,1,1 }
            // };
            // bool state = true;
            // 
            // ConsoleKeyInfo key;
            // Character character = new Character();
            // character.Shape = "★";
            // character.X = 16;
            // character.Y = 7;
            // 
            // while(state)
            // {               
            //     for (int i = 0; i < maze.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < maze.GetLength(1); j++)
            //         {
            //             if (maze[i, j] == 2) Console.Write("◎");
            //             else if (maze[i, j] == 1) Console.Write("■");
            //             else if (maze[i, j] == 0) Console.Write("  ");
            //         }
            //         Console.WriteLine();
            //     }
            //     
            //     Console.SetCursorPosition(character.X, character.Y);
            //     Console.Write(character.Shape);
            // 
            //     key = Console.ReadKey();
            //     character.Move(maze, key, ref state);
            // 
            //     Console.Clear();
            // }

            #endregion

            #region 인덱서
            // 객체의 인스턴스 변수에 대한 배열 형태의 접근 방법을 제공하는 기능입니다.

            // Bullet bullet = new Bullet();
            // 
            // for (int i = 0; i < 10; i++)
            // {
            //     bullet[i] = i + 1;
            //     Console.WriteLine("bullet [" + i + "]의 값 : " + bullet[i]);
            // }

            #endregion

            #region 무명 형식
            // 무명 형식의 경우 데이터를 접근하는 것은 불가능하지만,
            // 데이터를 출력하는 형태는 가능합니다.

            // var gameObject = new { grade = 'A', id = 100, name = "gameObject" };

            //gameObject.id = 99; (X)
            // Console.WriteLine("gameObject의 grade 값 : " + gameObject.grade);
            // Console.WriteLine("gameObject의 id 값 : " + gameObject.id);
            // Console.WriteLine("gameObject의 name 값 : " + gameObject.name);

            #endregion
        }
    }
}