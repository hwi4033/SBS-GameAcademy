namespace C__Sokoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pushbox1 = 5;
            int pushbox2 = 5;
            Screen screen = new Screen();
            Stages stages = new Stages();
            Player player = new Player(8, 1, "★");
            Boxes box1 = new Boxes(6, 3, "■");
            Boxes box2 = new Boxes(8, 4, box1.Shape);

            ConsoleKeyInfo key;
          
            while(true)
            {
                stages.Rendering(stages.stage1);
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);
                Console.SetCursorPosition(box1.X, box1.Y);
                Console.Write(box1.Shape);
                Console.SetCursorPosition(box2.X, box2.Y);
                Console.Write(box2.Shape);

                key = Console.ReadKey();
                player.Collider(stages.stage1, box1.X, box1.Y, ref pushbox1);
                player.Collider(stages.stage1, box2.X, box2.Y, ref pushbox2);

                player.Move(stages.stage1, key);

                box1.BoxMove(stages.stage1, player.X, player.Y, ref pushbox1);               
                box2.BoxMove(stages.stage1, player.X, player.Y, ref pushbox2);

                Console.Clear();
            }
        }
    }
}