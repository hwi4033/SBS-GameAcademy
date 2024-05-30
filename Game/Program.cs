namespace Game
{
    public class Snake
    {
        protected int x;
        protected int y;
    }
    class SnakeHead : Snake
    {

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
    }
    internal class Program
    {
        static void Map()
        {
            const int width = 10;
            const int height = 10;

            int[,] map = new int[width, height];

            if(width == 0 || height == 0) Console.Write("ㅁ")
        }
        static void Main(string[] args)
        {
            List <string> snake = new List <string> ();
            ConsoleKeyInfo key;
            snake.Add("◎");

            while(true)
            {
                key = Console.ReadKey();
                
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.RightArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break;
                }
            }
        }
    }
}