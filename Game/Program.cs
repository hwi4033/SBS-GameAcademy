using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

using Game;

namespace C__Sokoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            Stages stages = new Stages();
            Player player = new Player(8, 1, "★");
            Boxes[] boxes = {
                new Boxes(6, 3, "■"),
                new Boxes(8, 4, "■")
            };

            ConsoleKeyInfo key;

            while (true)
            {
                stages.Rendering(stages.stage1);
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);

                foreach (var box in boxes)
                {
                    Console.SetCursorPosition(box.X, box.Y);
                    Console.Write(box.Shape);
                }

                key = Console.ReadKey();
                player.Move(stages.stage1, boxes, key);

                foreach (var box in boxes)
                {
                    box.Move(stages.stage1, player.X, player.Y, key);
                }

                Console.Clear();
            }
        }
    }
}