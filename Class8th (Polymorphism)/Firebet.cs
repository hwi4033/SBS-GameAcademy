using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8th__Polymorphism_
{
    internal class Firebet : Unit
    {
        private int steampack;

        public Firebet()
        {
            health = 50;
            attack = 7;
            defense = 1;

            steampack = 5;
        }

        new public void Skill()
        {
            Console.WriteLine("SteamPack");
        }

        override public void Show()
        {
            Console.WriteLine("health 변수의 값 : " + health);
            Console.WriteLine("attack 변수의 값 : " + attack);
            Console.WriteLine("defense 변수의 값 : " + defense);
        }
    }
}
