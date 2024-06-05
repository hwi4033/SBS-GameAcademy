﻿using System.Runtime.CompilerServices;

namespace C__Sokoban
{
    internal class Program
    {
        static void UI(int moveCount)
        {
            Console.SetCursorPosition(4, 10);
            Console.Write("움직인 횟수 : " + moveCount);
            Console.SetCursorPosition(4, 12);
            Console.Write("방향키 : ↑, ←, →, ↓");
            Console.SetCursorPosition(4, 14);
            Console.Write("■ : 상자");
            Console.SetCursorPosition(4, 16);
            Console.Write("⊙ : 골인지점");
        }
        // static void RunGame(int stagenum)
        // {
        //     int pushbox1 = 0;
        //     int pushbox2 = 0;
        //     int pushbox3 = 0;
        //     Screen screen = new Screen();
        //     Stages stages = new Stages();
        //     Player player = new Player(8, 1, "★");
        //     Boxes box1 = new Boxes(6, 3, "■");
        //     Boxes box2 = new Boxes(8, 4, box1.Shape);
        //     Boxes box3 = new Boxes(6, 2, "■");
        //     ConsoleKeyInfo key;
        //     while (stagenum == 0)
        //     {
        //         stages.Rendering(stages.stage1);
        //         UI(player.moveCount);
        //         Console.SetCursorPosition(player.X, player.Y);
        //         Console.Write(player.Shape);
        //         Console.SetCursorPosition(box1.X, box1.Y);
        //         Console.Write(box1.Shape);
        //         Console.SetCursorPosition(box2.X, box2.Y);
        //         Console.Write(box2.Shape);
        // 
        //         key = Console.ReadKey();
        //         player.Collider(stages.stage1, box1.X, box1.Y, ref pushbox1);
        //         player.Collider(stages.stage1, box2.X, box2.Y, ref pushbox2);
        // 
        //         player.Move(stages.stage1, key, pushbox1);
        // 
        //         box1.BoxMove(stages.stage1, player.X, player.Y, ref pushbox1);
        //         box2.BoxMove(stages.stage1, player.X, player.Y, ref pushbox2);
        // 
        //         if (box1.X == 4 && box1.Y == 3 || box1.X == 2 && box1.Y == 4)
        //         {
        //             if (box2.X == 4 && box2.Y == 3 || box2.X == 2 && box2.Y == 4)
        //             {
        //                 stagenum += 1;
        //             }
        //         }
        //         Console.Clear();
        //     }
        //     player.X = 2;
        //     player.Y = 1;
        //     player.moveCount = 0;
        //     box1.X = 4;
        //     box1.Y = 3;
        //     box2.X = 4;
        //     box2.Y = 2;
        //     while (stagenum == 1)
        //     {
        //         stages.Rendering(stages.stage2);
        //         UI(player.moveCount);
        //         Console.SetCursorPosition(player.X, player.Y);
        //         Console.Write(player.Shape);
        //         Console.SetCursorPosition(box1.X, box1.Y);
        //         Console.Write(box1.Shape);
        //         Console.SetCursorPosition(box2.X, box2.Y);
        //         Console.Write(box2.Shape);
        //         Console.SetCursorPosition(box3.X, box3.Y);
        //         Console.Write(box3.Shape);
        // 
        //         key = Console.ReadKey();
        //         player.Collider(stages.stage2, box1.X, box1.Y, ref pushbox1);
        //         player.Collider(stages.stage2, box2.X, box2.Y, ref pushbox2);
        //         player.Collider(stages.stage2, box3.X, box3.Y, ref pushbox3);
        // 
        //         player.Move(stages.stage2, key, pushbox1);
        // 
        //         box1.BoxMove(stages.stage2, player.X, player.Y, ref pushbox1);
        //         box2.BoxMove(stages.stage2, player.X, player.Y, ref pushbox2);
        //         box2.BoxMove(stages.stage2, player.X, player.Y, ref pushbox3);
        // 
        //         if (box1.X == 4 && box1.Y == 3 || box1.X == 2 && box1.Y == 4)
        //         {
        //             if (box2.X == 4 && box2.Y == 3 || box2.X == 2 && box2.Y == 4)
        //             {
        //                 stagenum += 1;
        //             }
        //         }
        //         Console.Clear();
        //     }
        // }
        static void Main(string[] args)
        {
            int stagenum = 0;
            int pushbox1 = 0;
            int pushbox2 = 0;
            int pushbox3 = 0;
            Screen screen = new Screen();
            Stages stages = new Stages();
            Player player = new Player(8, 1, "★");
            Boxes box1 = new Boxes(6, 3, "■", 0);
            Boxes box2 = new Boxes(8, 4, box1.Shape, 0);
            Boxes box3 = new Boxes(6, 2, box1.Shape, 0);

            Boxes[] boxes = new Boxes[3] { box1, box2, box3 }; 
         
            ConsoleKeyInfo key;

            while (stagenum == 0)
            {
                stages.Rendering(stages.stage1);
                UI(player.MoveCount);
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);
                Console.SetCursorPosition(box1.X, box1.Y);
                Console.Write(box1.Shape);
                Console.SetCursorPosition(box2.X, box2.Y);
                Console.Write(box2.Shape);
                player.Crashbox = 0;
            
                key = Console.ReadKey();
                player.Collider(stages.stage1, box1.X, box1.Y, ref pushbox1);
                player.Collider(stages.stage1, box2.X, box2.Y, ref pushbox2);
            
                player.Move(stages.stage1, key, player.Crashbox);

                box1.BoxMove(stages.stage1, player.X, player.Y, pushbox1);
                box2.BoxMove(stages.stage1, player.X, player.Y, pushbox2);
            
                if (box1.X == 4 && box1.Y == 3 || box1.X == 2 && box1.Y == 4)
               {
                   if (box2.X == 4 && box2.Y == 3 || box2.X == 2 && box2.Y == 4)
                   {
                       stagenum += 1;
                   }
               }
                Console.Clear();
            }
            if (stagenum == 1)
            {
                player.X = 2;
                player.Y = 1;
                player.MoveCount = 0;
                box1.X = 4;
                box1.Y = 3;
                box2.X = 4;
                box2.Y = 2;
            }
            while(stagenum == 1)
            {
                stages.Rendering(stages.stage2);
                UI(player.MoveCount);
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);
                Console.SetCursorPosition(box1.X, box1.Y);
                Console.Write(box1.Shape);
                Console.SetCursorPosition(box2.X, box2.Y);
                Console.Write(box2.Shape);
                Console.SetCursorPosition(box3.X, box3.Y);
                Console.Write(box3.Shape);
                player.Crashbox = 0;
            
                key = Console.ReadKey();
                player.Collider(stages.stage2, box1.X, box1.Y, ref pushbox1);
                player.Collider(stages.stage2, box2.X, box2.Y, ref pushbox2);
                player.Collider(stages.stage2, box3.X, box3.Y, ref pushbox3);
            
                player.Move(stages.stage2, key, player.Crashbox);
            
                box1.BoxMove(stages.stage2, player.X, player.Y, pushbox1);
                box2.BoxMove(stages.stage2, player.X, player.Y, pushbox2);
                box3.BoxMove(stages.stage2, player.X, player.Y, pushbox3);
            
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