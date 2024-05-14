namespace Class2th__Bit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 변수의 이름 규칙

            // 1. 변수의 경우 중복된 변수의 이름을 허용하지 않습니다.
            // ex) int x = 10;
            //     int x = 20;

            // 2. 변수의 이름은 대소문자를 구분하여 사용할 수 있습니다.
            // ex) int y = 10;
            //     int Y = 20;

            // 3. 변수의 이름으로 예약어를 사용할 수 없습니다.
            // ex) int float = 20;

            // 4. 변수의 이름은 숫자로 시작할 수 없습니다.
            // ex) int directX9 = 0;    (O)
            //     int 5directX = 20;   (X)

            // 5. 변수의 이름으로 공백을 포함할 수 없습니다.
            // ex) int count Down = 10; (X)

            // 6. 변수의 이름으로 특수 문자는 _만 사용할 수 있습니다.
            // ex) int count_Down = 0;  (O)

            #endregion

            #region 표기법

            // 카멜 표기법 (Camel Case) : 변수명, 매서드에 사용하며 단어의 첫 글자는 소문자로 적으며 두 번째 단어부터는 첫 글자를 대문자로 적는다.
            // ex) int countDown;
            //     int myVariable
            //     int userName

            // 파스칼 표기법 (Pascal Case) : 함수, 클래스명에 사용하며 모든 단어의 첫 글자는 대문자로 적으며 공백이나 특수 문자를 
            // Pascal -> clss Program
            #endregion

            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할 수 없는 메모리 공간입니다.

            // const int data = 10;

            // data = 20;   (X)

            // Console.WriteLine("상수 data의 값 : " + data);

            // 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며, 한 번 저장된 값은 더 이상 변경할 수 없습니다.

            // 상수의 경우 메모리 공간을 가지고 있지 않은 상수를 '리터럴 상수'라고 하며,
            // 메모리 공간을 가지고 있는 상수를 '심볼릭 상수'라고 합니다.
            #endregion

            #region 산술연산자
            // int x = 5;
            // const int y = 3;
            // 
            // int result1 = x + x;
            // int result2 = x - 2;
            // int result3 = 2 * y;
            // int result4 = x / y;
            // int result5 = 3 % 2;
            // 
            // Console.WriteLine("result1의 값 : " + result1);
            // Console.WriteLine("result2의 값 : " + result2);
            // Console.WriteLine("result3의 값 : " + result3);
            // Console.WriteLine("result4의 값 : " + result4);
            // Console.WriteLine("result5의 값 : " + result5);
            #endregion

            #region 비트
            // 데이터를 나타내는 최소의 단위이며, 0 또는 1의 조합으로 논리 계산을 수행하는 단위입니다.

            // 메모리는 비트 단위로 데이터를 저장할 수 있으며, 1개의 비트에는 0 또는 1의 값만 저장할 수 있습니다.

            #region 10진수를 2진수로 변환하는 과정
            // 10진수를 1이 될 때까지 계속 2로 나누어 준 다음 나눈 위치의 나머지 값을 아래에서 위로 순서대로 정렬합니다.
            // 23 -> 0001 0111
            #endregion

            #region 2진수를 10진수로 변환하는 과정
            // 1 byte에 2진수로 저장된 값을 2의 제곱으로 나타내며,
            // 각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산한 다음 각각의 비트를 모두 더하여 10진수로 나타냅니다.
            #endregion

            #endregion

            #region 비트 연산자
            // 비트 단위로 논리 연산을 수행하기 위해 사용하는 연산자입니다.

            // int a = 15; // 0000 1111
            // int b = 10; // 0000 1010

            // AND 연산자 : &
            // 두 개의 피연산자가 모두 1이면 1을 반환하는 연산자입니다.
            // Console.WriteLine("a 변수와 b 변수를 AND 연산한 결과 : " + (a & b));
            // 0000 1010

            // OR 연산자 : |
            // 두 개의 피연산자 중에 하나라도 1이 있다면 1을 반환하는 연산자입니다.
            // Console.WriteLine("a 변수와 b 변수를 OR 연산한 결과 : " + (a | b));
            // 0000 1111

            // XOR 연산자 : ^
            // 두 개의 피연산자가 서로 같으면 0을 반환하고, 서로 다르면 1을 반환하는 연산자입니다.
            // Console.WriteLine("a 변수와 b 변수를 XOR 연산한 결과 : " + (a ^ b));
            // 0000 0101

            // NOT 연산자 : ~
            // 피연산자의 값을 반전시키는 연산자입니다.
            // Console.WriteLine("a 변수를 NOT 연산한 결과 : " + (~a));
            // 1111 0000 : -128 + 64 + 32 + 16 = -16

            // 첫 번째 비트는 부호를 나타내며 첫 번째 비트에 1이 있다면 값은 음수가 됩니다.
            #endregion

            #region 시프트 연산자
            // 0과 1로 이루어진 2진수를 왼쪽 또는 오른쪽으로 원하는 자리만큼 이동하는 연산자입니다.

            // int money = 10; // 0000 1010

            // Console.WriteLine("money 변수를 왼쪽으로 2번 shift 연산한 결과 : "+ (money << 2)); // 0010 1000

            // Console.WriteLine("money 변수를 오른쪽으로 2번 shift 연산한 결과 : " + (money >> 2)); // 0000 0010
            #endregion
        }
    }
}