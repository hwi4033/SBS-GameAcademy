namespace Class9th__Random_
{
    public class Computer : IMouse, IKeyboard
    {
        private int value;

        public int Value
        {
            get { return value; }
            set
            {
                if (value >= 31)
                {
                    Value = value;
                }
                else
                {
                    this.value = value;
                }
            }
        }

        public void Input()
        {
            Console.WriteLine("Input Keyboard");
        }

        public void Select()
        {
            Console.WriteLine("Select Mouse");
        }
    }

    abstract public class Vehicle
    {
        private string name;
        private float speed;
        abstract public void Move();
    }

    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bicycle Move");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Motorcycle Move");

        }
    }

    public interface IMouse
    {
        public void Select();
    }

    public interface IKeyboard
    {
        public void Input();
    }

    internal class Program
    {
        public delegate void Calculator(int x, int y);      // delegate 선언

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Hp(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("♥");
            }
        }

        static void Main(string[] args)
        {
            #region 랜덤 함수

            // Random random = new Random();             
            // while (true)
            // {
            //     int result = random.Next(0, 2);     // 최솟값에서 (최댓값 - 1)만큼 나온다.
            //     Console.WriteLine("result 변수의 값 : " + result);
            //     
            //     Console.ReadLine();
            //     Console.Clear();
            // }

            // while (true)
            // {
            //     int count = Convert.ToInt32(Console.ReadLine());
            //     
            //     Console.Clear();
            // 
            //     Hp(count);
            // }

            #endregion

            #region ASCII 코드
            // 미국 국가표준 협회에서 표준화한 정보 교환용 7 bit 부호체계입니다.

            // 문자 인코딩
            // 복잡한 신호를 0과 1의 디지털 신호로 변환하는 것입니다.

            // char alphabet = 'A';

            // Console.WriteLine("alphabet 변수의 값 : " + (int)alphabet);

            // for(int i = 0; i <= ('Z' - 'A'); i++)
            // (int i = 0; i < 26; i++)
            // {
            //     Console.WriteLine(alphabet + " : " + (int)alphabet);
            //     // console.write((char)('A' + i) + " ");
            //
            //     alphabet++;
            // }

            #endregion

            #region UP-DOWN 게임

            // Computer computer = new Computer();
            // Random random = new Random();
            // computer.Value = random.Next(1, 31);
            // 
            // int hp = 5;
            // 
            // while(true)
            // {
            //     Console.Clear();
            //     Hp(hp);
            //     Console.WriteLine('\n');
            // 
            //     int player = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine();
            // 
            //     if (player > computer.Value)
            //     {
            //         Console.WriteLine("컴퓨터가 가지고 있는 값보다 큽니다.");
            //         hp--;
            //     }
            //     else if (player < computer.Value)
            //     {
            //         Console.WriteLine("컴퓨터가 가지고 있는 값보다 작습니다.");
            //         hp--;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Victory!");
            //         break;
            //     }
            // 
            //     if(hp <= 0)
            //     {
            //         Console.WriteLine("DEFEAT");
            //         break;
            //     }
            //     Console.ReadLine();
            // }

            #endregion

            #region 추상 클래스 (abstract)
            // 추상 함수를 선언한 다음 상속을 통해 하위 클래스에서 함수를 완성하도록 유도하는 클래스입니다.

            // Vehicle vehicle = new Vehicle();
            // 추상 클래스는 인스턴스를 할 수 없습니다.

            // Bicycle bicycle = new Bicycle();
            // bicycle.Move();

            // Motorcycle motorcycle = new Motorcycle();
            // motorcycle.Move();

            #endregion

            #region 인터페이스
            // 관례상 이름 앞에 I를 붙인다.

            // Computer computer = new Computer();
            // computer.Select();
            // computer.Input();

            #endregion

            #region 대리자 (delegate)
            // 함수의 주소 값을 저장한 다음 함수를 대신 호출하는 기능입니다. (주소를 받으므로 참조 타입)
            // 함수의 이름이 함수의 시작 주소를 나타낸다.
            // 접근지정자 / delegate / 반환형 / delegate의 이름

            // Calculator calculator;

            // calculator = Add; 
            // calculator(10, 20);

            // calculator = Substract;
            // calculator(5, 10);

            // calculator = Multiply;
            // calculator(5, 5);

            // calculator = Divide;
            // calculator(20, 10);

            // 대리자는 함수의 반환형과 매개변수의 타입이 일치해야 합니다.
            #endregion

            #region 델리게이트 체인
            // 하나의 호출자에 여러 개의 함수를 등록해서 사용하는 기법입니다.

            // Calculator calculator;

            // calculator = Add;
            // calculator += Substract;
            // calculator += Multiply;
            // calculator += Divide;

            // calculator(5, 5);

            // Console.WriteLine("------------------------------");

            // calculator -= Divide;

            // calculator(10, 2);

            #endregion
        }
    }
}