using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8th__Polymorphism_
{
    internal class Ghost : Unit
    {
        public Ghost()
        {
            health = 40;
            attack = 8;
            defense = 0;
        }

        new public void Skill()
        {
            Console.WriteLine("LockDown");
        }

        override public void Show()
        {
            Console.WriteLine("health 변수의 값 : " + health);
            Console.WriteLine("attack 변수의 값 : " + attack);
            Console.WriteLine("defense 변수의 값 : " + defense);
        }
    }
}
