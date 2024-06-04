namespace C__Sokoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalcount;
            int stagenum = 0;
            int pushbox1 = 5;
            int pushbox2 = 5;
            int pushbox3 = 5;

            Screen screen = new Screen();
            Stages stages = new Stages();
            Player player = new Player(8, 1, "★");
            Boxes box1 = new Boxes(6, 3, "■");
            Boxes box2 = new Boxes(8, 4, box1.Shape);

            ConsoleKeyInfo key;

            while (stagenum == 0)
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

                if (box1.X == 4 && box1.Y == 3 || box1.X == 2 && box1.Y == 4)
                {
                    if (box2.X == 4 && box2.Y == 3 || box2.X == 2 && box2.Y == 4)
                    {
                        stagenum += 1;
                    }
                }
                Console.Clear();
            }

            Boxes box3 = new Boxes(6, 2, box1.Shape);
            player.X = 2;
            player.Y = 1;
            box1.X = 4;
            box1.Y = 3;
            box2.X = 4;
            box2.Y = 2;
            while(stagenum == 1)
            {
                stages.Rendering(stages.stage2);
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);
                Console.SetCursorPosition(box1.X, box1.Y);
                Console.Write(box1.Shape);
                Console.SetCursorPosition(box2.X, box2.Y);
                Console.Write(box2.Shape);
                Console.SetCursorPosition(box3.X, box3.Y);
                Console.Write(box3.Shape);

                key = Console.ReadKey();
                player.Collider(stages.stage2, box1.X, box1.Y, ref pushbox1);
                player.Collider(stages.stage2, box2.X, box2.Y, ref pushbox2);
                player.Collider(stages.stage2, box3.X, box3.Y, ref pushbox3);

                player.Move(stages.stage2, key);

                box1.BoxMove(stages.stage2, player.X, player.Y, ref pushbox1);
                box2.BoxMove(stages.stage2, player.X, player.Y, ref pushbox2);
                box2.BoxMove(stages.stage2, player.X, player.Y, ref pushbox3);

                if (box1.X == 4 && box1.Y == 3 || box1.X == 2 && box1.Y == 4)
                {
                    if (box2.X == 4 && box2.Y == 3 || box2.X == 2 && box2.Y == 4)
                    {
                        stagenum += 1;
                    }
                }
                Console.Clear();
            }
        }
    }
}