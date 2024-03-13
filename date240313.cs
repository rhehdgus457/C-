using System.Drawing;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
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

        #region class1
        //class Cat
        //{
        //    public string Name;
        //    public string Color;

        //    public void Meow()
        //    {
        //        Console.WriteLine($"{Name} : 야옹");
        //    }
        //}

        //class Cat
        //{
        //    public Cat()
        //    {
        //        Name = "";
        //        Color = "";
        //    }
        //    public Cat(string _Name, string _Color) 
        //    { 
        //        Name = _Name;
        //        Color = _Color;
        //    }

        //    ~Cat()
        //    {
        //        Console.WriteLine($"{Name} : 잘가");
        //    }
        //    public string Name;
        //    public string Color;

        //    public void Meow()
        //    {
        //        Console.WriteLine($"{Name} : 야옹");
        //    }
        //}

        //class Grobal
        //{
        //    public static int Count = 0;
        //}
        //class ClassA
        //{
        //    public ClassA()
        //    {
        //        Grobal.Count++;
        //    }
        //}
        //class ClassB
        //{
        //    public ClassB()
        //    {
        //        Grobal.Count++;
        //    }
        //}
        //class MyClass
        //{
        //    public int MyField1;
        //    public int MyField2;

        //    public MyClass DeepCopy()
        //    {
        //        MyClass newCopy = new MyClass();
        //        newCopy.MyField1 = this.MyField1;
        //        newCopy.MyField2 = this.MyField2;

        //        return newCopy;
        //    }
        //}

        //class Empolyee
        //{
        //    private string Name;
        //    private string Position;

        //    public void SetName(string Name)
        //    {
        //        this.Name = Name;
        //    }
        //    public string GetName()
        //    {
        //        return Name;
        //    }
        //    public void SetPosition(string Position) 
        //    {
        //        this.Position = Position;
        //    }
        //    public string GetPosition()
        //    {
        //        return this.Position;
        //    }
        //}

        //class MyClass
        //{
        //    int a, b, c;
        //    public MyClass()
        //    {
        //        this.a = 5425;
        //        Console.WriteLine("MyClas()");
        //    }
        //    public MyClass(int b) :this()
        //    {
        //        this.b = b;
        //        Console.WriteLine($"MyClass({b})");
        //    }
        //    public MyClass(int b, int c) :this(b)
        //    {
        //        this.c = c;
        //        Console.WriteLine($"MyClass({b}, {c})");
        //    }

        //    public void PrintFields()
        //    {
        //        Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        //    }
        //}
        //class WaterHeater
        //{
        //    protected int temperature;
        //    public void SetTemperature(int temperature)
        //    {
        //        if (temperature < -5 || temperature > 42)
        //        {
        //            throw new Exception("Out of temperature range");
        //        }
        //        this.temperature = temperature;
        //    }
        //    internal void TurnOnWater()
        //    {
        //        Console.WriteLine($"Turn on water : {temperature}");
        //    }
        //}
        #endregion

        #region Inheritance
        //class Base
        //{
        //    protected string Name;
        //    public Base(string Name)
        //    {
        //        this.Name = Name;
        //        Console.WriteLine($"{this.Name}.Base()");
        //    }
        //    ~Base()
        //    {
        //        Console.WriteLine($"{this.Name}.~Base()");
        //    }
        //    public void BaseMethod()
        //    {
        //        Console.WriteLine($"{Name}.BaseMethod()");
        //    }
        //}

        //class Derived : Base
        //{
        //    public Derived(string Name) : base(Name)
        //    {
        //        Console.WriteLine($"{this.Name}.Derived()");
        //    }
        //    ~Derived()
        //    {
        //        Console.WriteLine($"{this.Name}.~Derived()");
        //    }
        //    public void DerivedMethod() 
        //    {
        //        Console.WriteLine($"{Name}.DerivedMethod()");
        //    }
        //}


        #endregion

        #region TypeCasting
        //class Mammal
        //{ 
        //    public void Nurse()
        //    {
        //        Console.WriteLine("Nurse()");
        //    }
        //}
        //class Dog : Mammal
        //{ 
        //    public void Bark()
        //    {
        //        Console.WriteLine("Bark()");
        //    }
        //}
        //class Cat : Mammal
        //{
        //    public void Meow()
        //    {
        //        Console.WriteLine("Meow()");
        //    }
        //}


        #endregion

        #region Overriding
        //class ArmorSuite
        //{ 
        //    public virtual void Initialize()
        //    {
        //        Console.WriteLine("Armored");
        //    }
        //}
        //class IronMan : ArmorSuite
        //{
        //    public override void Initialize() 
        //    {
        //        base.Initialize();
        //        Console.WriteLine("Repulsor Rats Armed");
        //    }
        //}
        //class WarMachine : ArmorSuite
        //{
        //    public override void Initialize() 
        //    {
        //        base.Initialize();
        //        Console.WriteLine("Double-Barrel Cannons Armed");
        //        Console.WriteLine("Micro-Rocket Launcher Armed");
        //    }
        //}
        #endregion

        #region MethodHiding
        //class Base
        //{ 
        //    public void MyMethod()
        //    {
        //        Console.WriteLine("Base.MyMethod()");
        //    }
        //}
        //class Derived :Base
        //{
        //    public new void MyMethod()
        //    {
        //        Console.WriteLine("Derived.MyMethod()");
        //    }
        //}

        #endregion

        #region SealedMethod
        //class Base
        //{
        //    public virtual void SealMe()
        //    {

        //    }
        //}
        //class Derived : Base
        //{
        //    public sealed override void SealMe()
        //    {
        //    }
        //}
        //class WantToOverride : Derived
        //{
        //    public override void SealMe()
        //    {

        //    }
        //}
        #endregion

        #region ReadOnly
        //class Configuration
        //{
        //    private readonly int min;
        //    private readonly int max;
        //    public Configuration(int v1, int v2) 
        //    {
        //        min = v1;
        //        min = v2;
        //    }
        //    public void ChangedMax(int newMax)
        //    {
        //        max = newMax;
        //    }
        //}
        #endregion

        #region NestedClass
        //class Configuration
        //{
        //    List<ItemValue> listConfig = new List<ItemValue>();
        //    public void SetConfig(string item, string value)
        //    {
        //        ItemValue iv = new ItemValue();
        //        iv.SetValue(this, item, value);
        //    }
        //    public string GetConfig(string item)
        //    {
        //        foreach(ItemValue iv in listConfig) 
        //        {
        //            if(iv.GetItem() == item)
        //            {
        //                return iv.GetValue();
        //            }
        //        }
        //        return "";
        //    }
        //    private class ItemValue
        //    {
        //        private string item;
        //        private string value;
        //        public void SetValue(Configuration config, string item, string value)
        //        {
        //            this.item = item;
        //            this.value = value;

        //            bool found = false;
        //            for(int i = 0;i<config.listConfig.Count;i++) 
        //            {
        //                if (config.listConfig[i].item == item) 
        //                {
        //                    config.listConfig[i] = this;
        //                    found = true;
        //                    break;
        //                }
        //            }
        //            if (found == false)
        //            {
        //                config.listConfig.Add(this);
        //            }    
        //        }
        //        public string GetItem()
        //        { return item; }
        //        public string GetValue() 
        //        { return value; }

        //    }


        //}

        #endregion

        #region PartialClass
        partial class MyClass
        {
            public void Method1()
            {
                Console.WriteLine("Method1");
            }
            public void Method2()
            {
                Console.WriteLine("Method2");
            }
        }
        partial class MyCalss
        {
            public void Method3()
            {
                Console.WriteLine("Method3");
            }
            public void Method4()
            {
                Console.WriteLine("Method4");
            }
        }
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

            #region BasicClass
            //Cat kitty = new Cat();
            //kitty.Color = "하얀색";
            //kitty.Name = "키티";
            //kitty.Meow();
            //Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            //Cat nero = new Cat();
            //nero.Color = "검은색";
            //nero.Name = "네로";
            //nero.Meow();
            //Console.WriteLine($"{nero.Name} : {nero.Color}");
            #endregion

            #region Constructor
            //Cat kitty = new Cat("키티", "하얀색");
            //kitty.Meow();
            //Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            //Cat nero = new Cat("네로", "검은색");
            //nero.Meow();
            //Console.WriteLine($"{nero.Name} : {nero.Color}");
            #endregion

            #region StaticField
            //Console.WriteLine($"Grobal Count : {Grobal.Count}");

            //new ClassA();
            //new ClassA();
            //new ClassB();
            //new ClassB();

            //Console.WriteLine($"Grobal Count : {Grobal.Count}");
            #endregion

            #region DeepCopy
            //Console.WriteLine("Shallow Copy");

            //{
            //    MyClass source = new MyClass();
            //    source.MyField1 = 10;
            //    source.MyField2 = 20;

            //    MyClass target = source;
            //    target.MyField2 = 30;

            //    Console.WriteLine($"{source.MyField1} {source.MyField2}");
            //    Console.WriteLine($"{target.MyField1}, {target.MyField2}");
            //}

            //Console.WriteLine("Deep Copy");
            //{
            //    MyClass source = new MyClass();
            //    source.MyField1 = 10;
            //    source.MyField2 = 20;

            //    MyClass target = source.DeepCopy();
            //    target.MyField2 = 30;

            //    Console.WriteLine($"{source.MyField2}, {source.MyField2}");
            //    Console.WriteLine($"{target.MyField1}, {target.MyField2}");
            //}
            #endregion

            #region This
            //Empolyee pooh = new Empolyee();
            //pooh.SetName("Pooh");
            //pooh.SetPosition("Waiter");
            //Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            //Empolyee tigger = new Empolyee();
            //tigger.SetName("Tigger");
            //tigger.SetPosition("Cleaner");
            //Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");

            #endregion

            #region ThisConstructor
            //MyClass a = new MyClass();
            //a.PrintFields();
            //Console.WriteLine();

            //MyClass b = new MyClass(1);
            //b.PrintFields();
            //Console.WriteLine();

            //MyClass c = new MyClass(10, 20);
            //c.PrintFields();
            #endregion

            #region AccessModifier
            //try 
            //{
            //    WaterHeater heater = new WaterHeater();
            //    heater.SetTemperature(30);
            //    heater.TurnOnWater();

            //    heater.SetTemperature(-2);
            //    heater.TurnOnWater();

            //    heater.SetTemperature(50);
            //    heater.TurnOnWater();
            //}
            //catch (Exception e) 
            //{ 
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Inheritance
            //Base a = new Base("a");
            //a.BaseMethod();

            //Derived b = new Derived("b");
            //b.BaseMethod();
            //b.DerivedMethod();
            #endregion

            #region TypeCasting
            //Mammal mammal = new Dog();
            //Dog dog;

            //if (mammal is Dog)
            //{
            //    dog = (Dog)mammal;
            //    dog.Bark();
            //}

            //Mammal mammal2 = new Cat();

            //Cat cat = mammal as Cat;
            //if (cat != null)
            //{
            //    cat.Meow();
            //}

            //Cat cat2 = mammal as Cat;
            //if (cat2 != null)
            //{
            //    cat2.Meow();
            //}
            //else
            //{
            //    Console.WriteLine("cat2 is not a Cat");
            //}
            #endregion

            #region Overriding
            //Console.WriteLine("Creating ArmorSuite ...");
            //ArmorSuite armorsuite = new ArmorSuite();
            //armorsuite.Initialize();

            //Console.WriteLine("\nCreating IronMan ...");
            //IronMan ironman = new IronMan();
            //ironman.Initialize();

            //Console.WriteLine("\nCreating WarMachine ...");
            //WarMachine warmachine = new WarMachine();
            //warmachine.Initialize();

            #endregion

            #region MethodHiding
            //Base baseObj = new Base();
            //baseObj.MyMethod();

            //Derived derivedObj = new Derived();
            //derivedObj.MyMethod();

            //Base baseOrDerived = new Derived();
            //baseOrDerived.MyMethod();
            #endregion

            #region ReadOnly
            //Configuration c = new Configuration(100, 10);
            #endregion

            #region NestedClass
            //Configuration config = new Configuration();
            //config.SetConfig("Version", "V 5.0");
            //config.SetConfig("Size", "655,324 KB");

            //Console.WriteLine(config.GetConfig("Version"));
            //Console.WriteLine(config.GetConfig("Size"));

            //config.SetConfig("Version", "V 5.0.1");
            //Console.WriteLine(config.GetConfig("Version"));
            #endregion

            #region PartialClass
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            #endregion
        }
    }
}
