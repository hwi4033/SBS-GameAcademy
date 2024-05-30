namespace Game
{
    abstract public class Unit
    {
        protected int x;
        protected int y;
        protected string shape;
    }
    public class Player : Unit
    {
        public Player()
        {
            x = 10;
            y = 10;
            shape = "◎";
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
        public void Move(int[,] map, ConsoleKeyInfo key)
        {
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[y - 1, x / 2] != 1) y--;
                        break;
                case ConsoleKey.LeftArrow:
                    if (map[y, x / 2 - 1] != 1) x -= 2;
                    break;
                case ConsoleKey.RightArrow:
                    if (map[y, x / 2 + 1] != 1) x += 2;
                    break;
                case ConsoleKey.DownArrow:
                    if (map[y + 1, x / 2] != 1) y++;
                    break;
            }
        }
    }
    public class Box : Unit
    {
        public Box(int x, int y, string shape)
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
        public string Shape
        {
            get { return shape; }
            set { shape = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[7, 7] {
                {0,0,1,1,1,1,0 },
                {0,0,1,0,0,1,0 },
                {1,1,1,0,0,1,0 },
                {1,0,0,0,0,1,1 },
                {1,0,0,0,0,0,1 },
                {1,1,1,0,0,0,1 },
                {0,0,1,1,1,1,1 }
            };
            int i, j;           

            Player player = new Player();
            Box box1 = new Box(5,6,"■");

            player.X = 6;
            player.Y = 4;
            player.Shape = "◎";
            ConsoleKeyInfo key;
            
            while(true)
            {
                for (i = 0; i < map.GetLength(0); i++)
                {
                    for (j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == 0) Console.Write("  ");
                        else if (map[i, j] == 1) Console.Write("▩");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);
                Console.Write(box.Shape);

                key = Console.ReadKey();
                player.Move(map, key);

                Console.Clear();
            }
            
        }
    }
}