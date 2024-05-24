using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8th__Polymorphism_
{
    internal class Marine : Unit    // 상속 받고자 하는 상위 클래스의 이름을 적는다.
    {
        private int steamPack;

        public Marine()
        {
            health  = 40;
            attack  = 5;
            defense = 0;

            steamPack = 5;

            Console.WriteLine("Create Marine");
        }

        new public void Skill()
        {
            // 오버라이드를 표시하기 위해 new 키워드를 추가 (생략 가능)
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
