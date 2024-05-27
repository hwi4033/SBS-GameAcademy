using System.Collections;       // 

namespace Class10th__Collection_
{
    public class Vector<T>
    {
        private T[] array;

        public Vector()
        {
            array = new T[5];
        }

        public T Array
        {
            get { return array[0]; }
            set { array[0] = value; }
        }
    }
    internal class Program
    {
        public static void Debug<T>(T data)
        {
            Console.WriteLine("data 변수의 값 : " + data);
        }
        static void Main(string[] args)
        {
            #region 일반화 프로그래밍
            // 특정 데이터 타입에 의존하지 않고, 모든 타입을 멤버 변수의 타입으로 설정할 수 있는 프로그래밍 기법입니다.

            // Debug('A');
            // Debug(10);
            // Debug(20.5f);
            // Debug(57.85);
            // Debug("Hello World");

            // Vector<int> vector = new Vector<int>();

            // vector.Array = 20;

            // Console.WriteLine("vector의 [0] index 값 : " + vector.Array);

            // C++ 템플릿은 컴파일이 1번 일어나며,
            // C# 제네릭은 컴파일이 2번 일어난다.
            #endregion

            #region 컬렉션
            // 많은 데이터 요소를 효율적으로 관리하기 위한 자료 구조입니다.

            #region List

            // List<int> list = new List<int>();

            // list.Capacity = 5;

            // list.Add(10);    // [10] [  ] [  ] [  ] [  ]
            // list.Add(20);    // [10] [20] [  ] [  ] [  ]
            // list.Add(30);    // [10] [20] [30] [  ] [  ]
            // 
            // list.Remove(30); // [10] [20] [  ] [  ] [  ]
            // // list.RemoveAt(?);

            // for (int i = 0; i < list.Count; i++)
            // {
            //     Console.WriteLine("list [" + i + "]의 값 : " + list[i]);
            // }

            // Console.WriteLine("list의 Count 값 : " + list.Count);
            // Console.WriteLine("list의 Capacity 값 : " + list.Capacity);
            #endregion

            #region Linked List
            // Node1 -> Node2 -> Node3
            // 메모리 파편화, Node3에 접근하기 위해 Node1과 Node2를 거쳐야된다.
            // 마지막 Node의 다음 주소값은 null값을 가진다.
            // 사용 권장 안함

            // LinkedList<int> linkedList = new LinkedList<int>();

            // linkedList.AddFirst(10);    // [10]
            // linkedList.AddFirst(5);     // [5] -> [10]
            // linkedList.AddLast(99);     // [5] -> [10] -> [99]

            // linkedList.Remove(10);

            // linkedList[0]   (x)

            // foreach(int element in linkedList)
            // {
            //     Console.WriteLine(element);
            // }

            // Console.WriteLine("linkedList의 Count 값 : " + linkedList.Count);

            #endregion

            #region Stack
            // 메모리 구조의 Stack (X)
            // Last In First Out 구조.
            // index 접근 불가 

            // Stack<int> stack = new Stack<int>();

            // stack.Push(10); // [10]
            // stack.Push(20); // [20] [10]
            // stack.Push(30); // [30] [20] [10]
            // stack.Push(40); // [40] [30] [20] [10]
            // stack.Push(50); // [50] [40] [30] [20] [10]

            // stack[0]; (X)

            // stack.Pop();    // 가장 나중에 들어온 [50]이 빠진다.

            // Console.WriteLine("Stack의 Peek 값 : " + stack.Peek());    // 제일 앞의 값 출력
            // Console.WriteLine("Stack의 Count 값 : " + stack.Count());


            // int length = stack.Count();

            // for (int i = 0; i < length; i++)
            // {
            //     Console.WriteLine(stack.Peek());
            //     stack.Pop();
            // }

            #endregion

            #region Queue
            // First In First Out

            // Queue<int> queue = new Queue<int>();

            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.Enqueue(30);
            // queue.Enqueue(40);
            // queue.Enqueue(50);

            // queue.Dequeue();     // 먼저 들어온 값 뺴기

            // Console.WriteLine("queue의 count 값 : " + queue.Count);

            // foreach(int element in queue)
            // {
            //     Console.WriteLine("element의 값 : " + element);
            // }

            #endregion

            #region Dictionary
            // KEY / VALUE 형식의 KEY값으로 ...

            // Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // dictionary.Add("Sword", 10000);
            // dictionary.Add("Gloves", 7500);
            // dictionary.Add("Shoes", 2500);
            // dictionary.Add("Amor", 7500);
            // dictionary는 key 값의 중복을 허용하지 않습니다.
            // dictionary.Add("Sword", 10000);

            // if(dictionary.ContainsKey("Sword"))
            // {
            //     Console.WriteLine("Key 값이 존재합니다.");
            // }
            // else
            // {
            //     Console.WriteLine("Key 값이 존재하지 않습니다.");
            // }

            // foreach (KeyValuePair<string, int> item in dictionary)
            // {
            //     Console.WriteLine("item의 key 값 : " + item.Key);
            //     Console.WriteLine("item의 value 값 : " + item.Value);
            // }

            #endregion

            #endregion
        }
    }
}