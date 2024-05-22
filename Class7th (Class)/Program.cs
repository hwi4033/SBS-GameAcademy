﻿namespace Class7th__Class_
{
    public class GameObject
    {
        #region 바이트 패딩
        // 멤버 변수를 메모리에서 CPU로 읽을 때 한 번에 읽을 수 있도록,
        // 컴파일리가 레지스터 블록에 맞추어 바이트를 패딩해주는 최적화 작업입니다.

        // 클래스의 크기는 클래스를 구성하는 멤버 중에서 크기가 가장 큰 자료형의 배수가 되도록 설정합니다.

        // 클래스의 크기의 경우 멤버 변수의 순서에 따라 메모리 크기가 다르게 설정될 수 있습니다.
        // ex) int x;
        //     double weight;   -> 32 byte
        //     int y;
        #endregion

        private int x;  // 기본 접근 지정자는 private이다.
        private int y;
        private int z;

        private double weight;  // double X 4 = 32 byte

        public void Infomation()
        {
            Console.WriteLine("x의 값 : " + x);
            Console.WriteLine("y의 값 : " + y);
            Console.WriteLine("z의 값 : " + z);
        }
    }

    public class Collider
    {
        int size = 0;               // 지역멤버변수 선언
        static int score = 0;       // 정적멤버변수 선언 (DATA 영역에 메모리 생성) (클래스 영역에 포함안된다.)

        public void IncreaseScore()
        {
            score++;

            Console.WriteLine("score 변수의 값 : " + score);
        }
    }

    public class Unit
    {
        private int health;
        private string name;
        private int[] attack;

        public Unit(int health, string name)   // 생성자 (변수 초기화 시 사용 용이, 매개변수 사용 가능하며 this 포인터를 통해 멤버변수와 매개변수를 명시한다.)
        {
            // this 포인터
            // 자기 자신의 객체를 가리키는 포인터다.

            this.health = health;
            this.name = name;

            attack = new int[3];
        }

        public Unit(Unit unit)
        {
            health = unit.health;       // 값 타입은 복사
            name = unit.name;
            attack = new int[3];        // 참조 타입은 새로운 메모리 생성 (깊은 복사)
        }

        public void SetData(int value)
        {
            attack[0] = value;
        }

        public void Show()
        {
            Console.WriteLine("health 변수의 값 : " + health);
            Console.WriteLine("name 변수의 값 : " + name);

            for (int i = 0; i < attack.Length; i++)
            {
                Console.WriteLine("attack [" + i + "]" + " : " + attack[i]);
            }
        }
    }

    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("100 이상의 값이 들어왔습니다.");
                }
                else
                {
                    x = value;
                }
            }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

    }

    internal class Program
    {
        // public void Function()
        // { main 함수와 같은 클래스에 속하는 함수 }

        static void Main(string[] args)
        {
            // main 함수는 static으로 작성 (프로그램이 실행될 때 DATA 영역에 ...)
            // Program program = new Program();
            // program.Function();

            #region 클래스 (Class)
            // 사용자 정의 데이터 유형으로 속성(ex. 변수)과 함수가 포함되어 있으며, 클래스를 통해 객체를 생성하여 접근하고 사용할 수 있는 집합체입니다.

            // GameObject gameObject = new GameObject();

            // gameObject.Infomation();

            // 클래스의 경우 클래스 내부에 있는 변수는 클래스의 메모리 영역에 포함되지만, 정적 변수와 함수의 메모리는 클래스 영역에 포함되지 않습니다.
            #endregion

            #region 변수의 범위

            #region 지역변수
            // 선언된 블록(영역) {} 안에서만 사용할 수 있으며, 블록을 벗어나면 메모리에서 사라지는 특징을 가지고 있습니다.

            // {
            //     int data = 10;

            //     GameObject gameObject1 = new GameObject();
            // }

            // gameObject1.Infomation();   (X) // Stack 영역의 메모리는 사라지지만 Heap 영역의 메모리는 남아있어 메모리 소유권을 잃게 된다.
            // data = 20;   (X)

            #endregion

            #region 정적변수
            // 프로그램이 실행될 때 단 한 번만 초기화가 이루어지며
            // 프로그램이 실행될 때 메모리에 생성되고, 프로그램이 종료되어야만 메모리에서 사라지는 특징을 가지고 있습니다.

            // Collider collider = new Collider();
            // 
            // collider.IncreaseScore();
            // collider.IncreaseScore();
            // collider.IncreaseScore();
            // collider.IncreaseScore();
            // collider.IncreaseScore();

            #endregion

            #endregion

            #region 생성자
            // 클래스의 인스턴스가 생성되는 시점에 자동으로 호출되는 특수한 멤버변수입니다.

            // Unit unit1 = new Unit(40, "Marine");    
            // Unit unit2 = new Unit(100, "Zealot");
            // Unit unit3 = new Unit(35, "Zuggling");

            // 생성자의 경우 객체가 생성될 때 단 한 번만 호출되며,
            // 생성자는 반환형이 존재하지 않기 때문에 호출되기 전에는 객체에 대한 메모리가 할당되지 않습니다.
            #endregion

            #region 얕은 복사
            // 객체를 복사할 때 값을 복사하여 같은 메모리를 가리키게 하는 복사입니다.
            // 나무같은 오브젝트를 대량으로 생성해야 할 때..

            // Unit unit1 = new Unit(20, "Slime");
            // unit1.Show();
            // 
            // Unit unit2 = unit1;
            // unit2.Show();

            // 얕은 복사의 경우 같은 객체가 서로 같은 메모리 공간을 참조하고 있기 때문에
            // 하나의 객체로 값을 변경하게 되면 서로 참조된 객체도 함께 영향을 받습니다.
            #endregion

            #region 복사 생성자
            // 같은 객체를 복사하여 생성시킬 때 호출되는 생성자입니다.

            // Unit skeleton1 = new Unit(30, "Skeleton");
            // Unit skeleton2 = new Unit(skeleton1);
            //
            // skeleton1.SetData(10);
            // skeleton2.SetData(20);
            //
            // skeleton1.Show();
            // skeleton2.Show();

            // 복사 생성자를 정의하지 않고 객체를 복사하게 되면 기본 복사 생성자가 호출되기 때문에 얕은 복사로 객체가 복사됩니다.
            #endregion

            #region 깊은 복사
            // 객체를 복사할 때, 참조 값이 아닌 인스턴스 자체를 새로 복사하여 서로 다른 메모리를 생성하는 복사입니다.

            // Unit slime1 = new Unit(30, "Slime");
            // Unit slime2 = new Unit(slime1);

            // slime1.SetData(10);
            // slime2.SetData(20);

            // slime1.Show();
            // slime2.Show();

            #endregion

            #region 가비지 컬렉터
            // 시스템에서 더 이상 사용하지 않는 메모리를 찾은 다음 자동으로 해제하는 기법입니다.
            // C# -> 세대기반
            // UNITY -> LOH (large of heap) / SOH (small of heap)
            #endregion

            #region 프로퍼티
            // set에 조건을 걸어 예기치 못한 값을 막을 수 있다.

            // Position position1 = new Position();

            // position1.X = 200;   // SETTER
            // position1.Y = 20;

            // Console.WriteLine("position.X : " + position1.X);   // GETTER
            // Console.WriteLine("position.Y : " + position1.Y);   

            #endregion
        }
    }
}