using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stages stages = new Stages();
            Player player = new Player();           
            
            player.X = 6;
            player.Y = 4;
            player.Shape = "★";
            ConsoleKeyInfo key;
            
            while(true)
            {
                stages.Rendering(stages.stage1);

                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);

                key = Console.ReadKey();
                player.Move(stages.stage1, key);

                Console.Clear();
                stages.Add();
            }          
        }
    }
}