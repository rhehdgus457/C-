using System.Net.WebSockets;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Method1
        //public static int Plus(int a, int b)
        //{
        //    return a + b;
        //}
        //public static int Minus(int a, int b)
        //{
        //    return a - b;
        //}

        //static int Fiboacci(int n)
        //{
        //    if(n<2)
        //    {
        //        return n;
        //    }
        //    else
        //    {
        //        return Fiboacci(n - 1) + Fiboacci(n - 2);
        //    }
        //}

        //static void PrintProfile(string strName, string strPhone)
        //{
        //    if (strName == "")
        //    {
        //        Console.WriteLine("이름을 입력해주세요");
        //        return;
        //    }
        //    Console.WriteLine($"Name: {strName}, Phone : {strPhone}");
        //}

        //public static void Swap(ref int a, ref int b)
        //{
        //    int tmp = b;
        //    b = a;
        //    a = tmp;
        //}

        //class Product
        //{
        //    private int iPrice = 100;

        //    public ref int GetPrice()
        //    {
        //        return ref iPrice;
        //    }
        //    public void PrintPrice()
        //    {
        //        Console.WriteLine($"Price:{iPrice}");
        //    }
        //}

        //static void Divide(int a, int b, out int quotient, out int remainder)
        //{
        //    quotient = a / b;
        //    remainder = a % b;
        //}
        #endregion

        #region Method2
        //static int Plus(int a, int b)
        //{
        //    Console.WriteLine("Calling int Plus(int, int)...");
        //    return a + b;
        //}
        //static int Plus(int a, int b, int c)
        //{
        //    Console.WriteLine("Calling int Plus(int, int, int)...");
        //    return a + b + c;
        //}
        //static double Plus(double a, double b) 
        //{
        //    Console.WriteLine("Calling double Plus(double, double)...");
        //    return a + b;
        //}
        //static double Plus(int a, double b)
        //{
        //    Console.WriteLine("Calling double Plust(int, double)...");
        //    return a + b;
        //}

        //static int Sum(params int[] args)
        //{
        //    Console.WriteLine("Summing ... ");
        //    int iSum = 0;
        //    for(int i = 0;i<args.Length; i++) 
        //    { 
        //        if(i>0)
        //        {
        //            Console.Write(", ");
        //        }
        //        else
        //        {

        //        }
        //        Console.Write(args[i]);
        //        iSum = args[i];
        //    }
        //    Console.WriteLine();
        //    return iSum;
        //}

        //static void PrintProfile(string strName, string strPhone)
        //{
        //    Console.WriteLine($"Name:{strName}, Phone:{strPhone}");
        //}

        //strPhone 에 "" 초기화하여 PrintProgfile에 strPhone 값을 넣지 않아도 할당되도록 함
        //static void PrintProfile(string strName, string strPhone = "")
        //{
        //    Console.WriteLine($"Name:{strName}, Phone:{strPhone}");
        //}

        //static string ToLowerString(string strInput)
        //{
        //    var arr = strInput.ToCharArray();
        //    for(int i =0;i< arr.Length; i++)
        //    {
        //        arr[i] = ToLowerChar(i);
        //    }

        //    char ToLowerChar(int i)
        //    {
        //        if (arr[i] < 65 || arr[i] > 90) //A to Z ASCII value : 65 ~ 90
        //        {
        //            return arr[i];
        //        }
        //        else // a to z ASCII value : 97 ~ 122
        //        {
        //            return (char)(arr[i] + 32);
        //        }
        //    }
        //    return new string(arr);
        //}
        #endregion

        static void Main(string[] args)
        {
            #region 1-8
            //byte[] bName;
            //byte[] bPW;
            //byte[] bCode;
            //byte[] bDeCode;
            //string strCode = "";
            //string strDeCode = "";
            //bool blCode = false;

            //Console.WriteLine("이름을 입력해주세요.");
            //string strInputID = Console.ReadLine();
            //bName = Encoding.Unicode.GetBytes(strInputID);

            //bCode = new byte[bName.Length];
            //bDeCode = new byte[bName.Length];

            //strDeCode = strInputID;

            //int iCase = 0;
            //string strInputPW = "";
            //do
            //{
            //    Console.WriteLine("1: 현재 데이터 보기 2: 암호화 3: 복호화 4: 나가기");
            //    string strCase = Console.ReadLine();
            //    iCase = Int32.Parse(strCase);

            //    switch (iCase)
            //    {
            //        case 1:
            //            {
            //                Console.WriteLine("현재 데이터는 : ");
            //                if (blCode)
            //                {
            //                    Console.WriteLine($"{strCode}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{strDeCode}");
            //                }
            //                break;
            //            }
            //        case 2:
            //            {
            //                blCode = true;
            //                if(blCode)
            //                {
            //                    Console.WriteLine("암호화할 번호를 입력해주세요.");
            //                    strInputPW = Console.ReadLine();
            //                    bPW = Encoding.Unicode.GetBytes(strInputPW);
            //                    Console.WriteLine("암호화 중 ...");
            //                    int tmp = 0;
            //                    for (int i = 0; i < bName.Length; i++)
            //                    {
            //                        bCode[i] = (byte)(bName[i] ^ bPW[tmp]);
            //                        tmp = ++tmp % bPW.Length;
            //                    }
            //                    strCode = Encoding.Unicode.GetString(bCode);
            //                    Console.WriteLine($"{strCode}");
            //                }
            //                else
            //                {

            //                }
            //                break;
            //            }
            //        case 3:
            //            {
            //                if (blCode)
            //                {
            //                    bPW = Encoding.Unicode.GetBytes(strInputPW);
            //                    blCode = false;
            //                    Console.WriteLine("복호화 중 ...");
            //                    int tmp2 = 0;
            //                    for (int i = 0; i < bName.Length; i++)
            //                    {
            //                        bDeCode[i] = (byte)(bCode[i] ^ bPW[tmp2]);
            //                        tmp2 = ++tmp2 % bPW.Length;
            //                    }
            //                    strDeCode = Encoding.Unicode.GetString(bDeCode);
            //                    Console.WriteLine($"{strDeCode}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("암호화되지 않았습니다.");
            //                }
            //                break;
            //            }
            //        case 4:
            //            {
            //                Console.WriteLine("나가기");
            //                break;
            //            }
            //    }

            //} while (iCase != 4);
            #endregion

            #region Ex
            //int a, b;
            //a = 3;
            //b = 4;
            //Console.WriteLine("Input : {0}, {1}", a, b);
            //int x = a + b; // x는 7

            //a = 5;
            //b = 6;
            //Console.WriteLine("Input : {0}, {1}", a, b);
            //int y = a + b; // y는 11

            //a = 7;
            //b = 8;
            //Console.WriteLine("Input : {0}, {1}", a, b);
            //int z = a + b; //z는 15
            #endregion

            #region Calculator
            //int iResult = Program.Plus(3, 4);
            //Console.WriteLine(iResult);
            //iResult = Program.Minus(5, 2);
            //Console.WriteLine(iResult);
            #endregion

            #region Fibonacci
            //Console.WriteLine($"10번째 피보나치 수 : {Fiboacci(10)}");

            //PrintProfile("", "123-4567");
            //PrintProfile("박상현", "456-1230");
            #endregion

            #region SwapByValue
            //int x = 3;
            //int y = 4;

            //Console.WriteLine($"x:{x}, y:{y}");

            //Swap(x, y);

            //Console.WriteLine($"x:{x}, y:{y}");
            #endregion

            #region SwapByRef
            //int x = 3;
            //int y =4;

            //Console.WriteLine($"x:{x}, y:{y}");

            //Swap(ref x, ref y);
            //Console.WriteLine($"x:{x}, y:{y}");
            #endregion

            #region RefReturn
            //Product carrot = new Product();
            //ref int ref_local_price = ref carrot.GetPrice();
            //int normal_local_price = carrot.GetPrice();

            //carrot.PrintPrice();
            //Console.WriteLine($"Ref Local Price : {ref_local_price}");
            //Console.WriteLine($"Normal Local Price : {normal_local_price}");

            //ref_local_price = 200;

            //carrot.PrintPrice();
            //Console.WriteLine($"Ref Local Price : {ref_local_price}");
            //Console.WriteLine($"Normal Local Price : {normal_local_price}");
            #endregion

            #region UsingOut
            //int a = 20;
            //int b = 3;
            ////int c;
            ////int d;

            //Divide(a, b, out int c, out int d);

            //Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
            #endregion

            #region OverLoading
            //Console.WriteLine(Plus(1, 2));
            //Console.WriteLine(Plus(1, 2, 3));
            //Console.WriteLine(Plus(1.0, 2.4));
            //Console.WriteLine(Plus(1, 2.4));
            #endregion

            #region UsingParams
            //int iSum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            //Console.WriteLine($"iSum : {iSum}");
            #endregion

            #region NamedParameter
            //PrintProfile(strName: "박찬호", strPhone: "010-123-1234");
            //PrintProfile(strPhone: "010-987-9876", strName: "박지성");
            //PrintProfile("박세리", "010-222-2222");
            //PrintProfile("박상현", strPhone: "010-567-5678");
            #endregion

            #region OptionalParameter
            //PrintProfile("중근");
            //PrintProfile("관순", "010-123-1234");
            //PrintProfile(strName: "봉길");
            //PrintProfile(strName: "동주", strPhone: "010-789-7890");
            #endregion

            #region LocalFunction
            //Console.WriteLine(ToLowerString("Hello!"));
            //Console.WriteLine(ToLowerString("Good Morning."));
            //Console.WriteLine(ToLowerString("This is C#."));
            #endregion
        }
    }
}
