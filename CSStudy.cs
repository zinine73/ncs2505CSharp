#define TEST_ENV
//#define PROD_ENV

using System.Collections;
using System.Text;
using Zinine;
using MyExtension;
// Forms를 사용하려면 csproj에 <itemgroup> 추가 필요
using System.Windows.Forms;
using System.Diagnostics;
// Regular Expression을 사용하려면 선언 필요
using System.Text.RegularExpressions;
using System.Data;

public class CSStudy
{
    public class Orders
    {
        public int Order_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Ship_City { get; set; }
        public DateTime Order_Date { get; set; }
    }
    public void LiNQSample()
    {
        var db = new List<Orders>
        {
            new Orders {Order_ID = 3, Customer_ID = "FRANS",
            Ship_City = "SEOUL", Order_Date = new DateTime(2025, 9, 17)},
            new Orders {Order_ID = 1, Customer_ID = "DAVID",
            Ship_City = "BUSAN", Order_Date = new DateTime(2025, 9, 20)},
            new Orders {Order_ID = 2, Customer_ID = "FRANS",
            Ship_City = "BUSAN", Order_Date = new DateTime(2025, 8, 10)}
        };
        // Query식 표현
        // var fransOrder = from ord in db
        //                  where ord.Customer_ID == "FRANS"
        //                  orderby ord.Order_Date ascending
        //                  select ord;
        //  select new
        //  {
        //      Id = ord.Order_ID,
        //      City = ord.Ship_City.ToLower()
        //  };
        // Method식 표현
        var fo = db.Where(o => o.Customer_ID == "FRANS");//.Select(o => o);
        foreach (var o in fo)
        {
            //Console.WriteLine($"{o.Order_ID}:{o.Order_Date}");
            //Console.WriteLine($"{o.Id} : {o.City}");
        }
        //var v = db.Where(o => o.Ship_City == "SEOUL").SingleOrDefault();
        //var v = db.Where(o => o.Customer_ID == "FRANS").FirstOrDefault();
        //var v = db.Where(o => o.Customer_ID == "FRANS").OrderBy(m => m.Order_ID);
        var v = db.Where(o => o.Customer_ID == "FRANS").Select(p => new
        {
            Id = p.Order_ID,
            City = p.Ship_City.ToLower()
        });
        if (v != null)
        {
            //Console.WriteLine($"{v.Order_Date}");
            foreach (var o in v)
            {
                Console.WriteLine($"{o.Id} : {o.City}");
            }
        }
    }

    public void OutSample()
    {
        // int x, y;
        // GetData(0, 1, out x, out y);
        //GetData(0, 1, out int x, out int y);
        GetData(0, 1, out var x, out var y);
        GetData(0, 1, out var z, out _);
        Console.WriteLine($"{x}, {y}, {z}");
    }

    (int count, int sum, double average) Calculate(List<int> data)
    {
        int cnt = 0, sum = 0;
        double avg = 0;
        foreach (var item in data)
        {
            cnt++;
            sum += item;
        }
        avg = sum / cnt;
        return (cnt, sum, avg);
    }

    public void TupleTest()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        //var r = Calculate(list);
        //Console.WriteLine($"{r.count}, {r.sum}, {r.average}");
        //Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}");
        //(int cnt, int sum, double avg) = Calculate(list);
        //(var cnt, var sum, var avg) = Calculate(list);
        //var (cnt, sum, avg) = Calculate(list);
        int cnt, sum;
        double avg;
        (cnt, sum, avg) = Calculate(list);
        Console.WriteLine($"cnt={cnt}, sum={sum}");
        (cnt, sum) = (sum, cnt);
        Console.WriteLine($"cnt={cnt}, sum={sum}");
    }

    class Employee
    {
        int id;
        string[] tags = new string[10];
        // 생성자
        // public Employee(int id)
        // {
        //     this.id = id;
        // }
        public Employee(int id) => this.id = id;
        // Finalizer
        // ~Employee()
        // {
        //     Debug.Write("~Employee");
        // }
        ~Employee() => Debug.Write("~Employee");
        // Property
        public int Id
        {
            // get
            // {
            //     return this.id;
            // }
            // set
            // {
            //     this.id = value > 0 ? value : 0;
            // }
            get => this.id;
            set => this.id = value > 0 ? value : 0;
        }
        // indexer
        public string this[int index]
        {
            // get
            // {
            //     return tags[index];
            // }
            // set
            // {
            //     tags[index] = value;
            // }
            get => tags[index];
            set => tags[index] = value;
        }
        // event
        EventHandler notified;
        public event EventHandler Notified
        {
            add => this.notified += value;
            remove => this.notified -= value;
        }
    }

    class Person
    {
        // public string Name
        // {
        //     get
        //     {
        //         return Name;
        //     }
        //     set
        //     {
        //         Name = value;
        //     }
        // }
        //public string Name { get; set; }
        public string Name { get; set; } = "(No name)";
        public string Nickname { get; }
        public int Age { get; }
        //public bool Enabled { get; } = true;
        public bool Enabled => true;
        public int Level { get; }
        public Person()
        {
            this.Level = 1;
        }

        int height = 3;
        int width = 2;
        // public int Area
        // {
        //     get
        //     {
        //         return height * width;
        //     }
        // }
        public int Area => height * width;

        string strData = "EBM";
        // public void Print()
        // {
        //     Console.WriteLine(strData);
        // }
        public void Print() => Console.WriteLine(strData);

        int salary;
        /*
        public int Salary
        {
            get
            {
                //if (salary < 0) salary = 0;
                //return salary;
                return (salary < 0) ? 0 : salary;
            }
        }
        */
        //public int Salary => salary;
        public int Salary => (salary < 0) ? 0 : salary;
    }
    public void AutoProperty()
    {
        Person p = new Person();
        //Console.WriteLine(p.Name);
        //Console.WriteLine(p.Nickname);
        //Console.WriteLine(p.Age);
        //Console.WriteLine(p.Area);
        p.Print();
    }

    public void DicInit()
    {
        // old
        var score1 = new Dictionary<string, int>()
        {
            {"kim", 100},
            {"lee", 90}
        };
        int sc1 = score1["lee"];
        // new
        var score2 = new Dictionary<string, int>()
        {
            ["kim"] = 100,
            ["lee"] = 90
        };
        int sc2 = score2["lee"];

        var A = new[] { 1, 2, 3 };
        var L = new List<int>(A) { [2] = 9 };
        Console.WriteLine($"{L[0]}, {L[2]}");
    }

    public event EventHandler Clicked;
    public void Click1()
    {
        var tempClicked = Clicked;
        if (tempClicked != null)
        {
            tempClicked(this, null);
        }
    }

    public void Click2() => Clicked?.Invoke(this, null);
    // {
    //     Clicked?.Invoke(this, null);
    // }

    public void NullSample()
    {
        List<int> rows = new List<int>();
        int? cnt = rows?.Count;

        // int cnt2;
        // if (rows == null)
        // {
        //     cnt2 = 0;
        // }
        // else
        // {
        //     cnt2 = rows.Count;
        // }
        int cnt2 = rows?.Count ?? 0;
    }

    public void RegexSample()
    {
        string str = "서울시 강남구 역삼동 강남아파트";
        Regex regex = new Regex("강남");
        //Match m = regex.Match(str);
        MatchCollection mc = regex.Matches(str);
        // if (m.Success)
        // {
        //     Console.WriteLine($"{m.Index}:{m.Value}");
        // }
        // while (m.Success)
        // {
        //     Console.WriteLine($"{m.Index}:{m.Value}");
        //     m = m.NextMatch();
        // }
        foreach (Match m in mc)
        {
            //Console.WriteLine($"{m.Index}:{m.Value}");
        }

        string pn = "015-1234-5555";
        Regex regex1 = new Regex(@"^01[01678]-[0-9]{4}-[0-9]{4}$");
        if (regex1.IsMatch(pn))
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("Miss Match");
        }
        string name = "김공A";
        regex1 = new Regex(@"^[가-힣]{3}$");
        if (regex1.IsMatch(name))
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("Miss Match");
        }
    }   

    public void PartialTest()
    {
        Class1 c1 = new Class1();
        c1.Get();
        c1.Put();
        c1.Run();

        Struct1 s1 = new Struct1(123, "Kim");
        Console.WriteLine($"{s1.ID}, {s1.Name}");
    }

    public void ExTest2()
    {
        var nums = new List<int> { 55, 44, 33, 66, 11 };
        var v = nums.Where(p => p % 3 == 0);
        List<int> arr = v.ToList<int>();
        arr.ForEach(x => Console.WriteLine(x));
    }

    public void ExtensionTest()
    {
        string s = "This is a Test";
        string s2 = s.ToChangeCase();
        bool found = s.Found('z');
        Console.WriteLine($"{s2}, found:{found}");
    }

    public void AnoTypeTest()
    {
        var v = new[] {
            new {Name="Lee", Age=33, Phone="02-111-1111"},
            new {Name="Kim", Age=25, Phone="02-222-2222"},
            new {Name="Park", Age=37, Phone="02-333-3333"}
        };
        var list = v.Where(p => p.Age >= 30).
            Select(p => new { p.Name, p.Age });
        foreach (var item in list)
        {
            Debug.WriteLine($"{item.Name} {item.Age}");
        }
    }

    class MyArea : Form // using System.Windows.Forms; 필요
    {

        delegate void MyDelegate(int a);
        public void AnoTest()
        {
            //var de = delegate (int p1) { Console.Write(p1); };
            // delegate 원래 쓰는 법
            MyDelegate dd = new MyDelegate(AnoMe);
            void AnoMe(int p1)
            {
                Console.Write(p1);
            }
            // 위에꺼를 무명메서드로 줄여 쓰는 법
            MyDelegate d = delegate (int p1)
            {
                Console.Write(p1);
            };
        }
        public MyArea()
        {
            //this.MouseClick += delegate { MyAreaClicked(); };
            MouseClick += (s, e) => MyAreaClicked();
        }
        public delegate void ClickDelegate(object sender);
        // delegate field => event field
        public event ClickDelegate MyClick;
        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                MyClick(this);
            }
        }
    }
    MyArea area;
    public void TestMyArea()
    {
        area = new MyArea();
        area.MyClick += Area_Click;
        area.MyClick += AfterClick;
        area.MyClick -= Area_Click;
        // event일때는 사용 불가
        //area.MyClick = Area_Click;
        //area.MyClick = null;
        area.ShowDialog();

        // 무명메서드
        area.Click += new EventHandler(delegate (object s, EventArgs a)
            { MessageBox.Show("OK"); });
        area.Click += (EventHandler)delegate (object s, EventArgs a)
            { MessageBox.Show("OK"); };
        area.Click += delegate (object s, EventArgs a)
            { MessageBox.Show("OK"); };
        area.Click += delegate
            { MessageBox.Show("OK"); };
        // 람다식
        area.Click += (s, a) => MessageBox.Show("OK");
    }

    void Area_Click(object sender)
    {
        area.Text += " MyArea 클릭!";
    }
    void AfterClick(object sender)
    {
        area.Text += " AfterClick 클릭!";
    }

    public void CompareRun()
    {
        int[] a = { 5, 53, 3, 7, 1 };
        // 올림차순 정렬
        Util.ComapreDelegate compDele = Util.AscendingCompare;
        Util.Sort(a, compDele);
        // 내림차순 정렬
        compDele = Util.DescendingCompare;
        Util.Sort(a, compDele);
    }

    // 1.delegate 선언
    delegate void RunDelegate(int i);
    void RunThis(int val)
    {
        Console.WriteLine($"{val}");
    }
    void RunThat(int value)
    {
        //Console.WriteLine("0x{0:X}", value);
        Console.WriteLine($"0x{value:X}");
    }
    public void DelePerform()
    {
        // 2. delegate 인스턴스 생성
        //RunDelegate run = new RunDelegate(RunThis);
        RunDelegate run = RunThis;
        // 3. delegate 실행
        run(1024);
        //run = new RunDelegate(RunThat);
        run = RunThat;
        run(1024);
    }
    // delegate 정의
    delegate int MyDelegate(string s);
    public void DeleTest()
    {
        // delegate 객체 생성
        MyDelegate m = new MyDelegate(StringToInt);
        // delegate 객체를 메서드로 전달
        DeleRun(m);
    }
    // delegate 대상이 되는 메서드
    int StringToInt(string s)
    {
        return int.Parse(s);
    }
    // delegate를 전달 받는 메서드
    void DeleRun(MyDelegate mmm)
    {
        // delegate로부터 메서드 실행
        int i = mmm("123"); // m.invoke("123);
        Console.WriteLine(i);
    }

    public void InterfaceTest()
    {
        ILogger logger = new ConsoleLogger();
        //ILogger logger = new FileLogger("MyText.text");
        //logger.WriteLog("Hello, World!");
        ClimateMonitor monitor =
            new ClimateMonitor(logger);
        monitor.Start();
    }

    class MyStack<T>
    {
        T[] _elements;
        int pos = 0;
        public int Pos
        {
            get { return pos; }
        }
        public MyStack()
        {
            _elements = new T[100];
        }
        public void Push(T element)
        {
            _elements[++pos] = element;
        }
        public T Pop()
        {
            return _elements[pos--];
        }
    }

    public void GenericSample()
    {
        MyStack<int> numberStack = new MyStack<int>();
        //MyStack<string> nameStack = new MyStack<string>();
        var nameStack = new MyStack<string>();
        numberStack.Push(14);
        numberStack.Push(20);
        numberStack.Push(5);
        Console.WriteLine($"{numberStack.Pop()}, pos:{numberStack.Pos}");
        nameStack.Push("thrusday");
        Console.WriteLine(nameStack.Pop());
    }

    public void ClassSample()
    {
        Console.WriteLine("***** Class Test *****");
        Animal anione = new Animal();
        anione.Name = "cat";
        anione.Age = 5;
        anione.SetGold(1000);
        Console.WriteLine($"Gold:{anione.GetGold()}");
        Dog myDog = new Dog();
        myDog.Name = "puppy";
        myDog.Age = 8;
        myDog.SetWeight(30);
        myDog.HowOld();
        myDog.SetGold(2000);
        Console.WriteLine($"Gold:{myDog.GetGold()}");
        Bird myBird = new Bird();
        myBird.Name = "seossi";
        myBird.Fly();

        /*
        // 이건 안됨
        //PureBase pb = new PureBase();
        DerivedA da = new DerivedA();
        Console.WriteLine(da.GetFirst());
        Console.WriteLine(da.GetNext());
        Console.WriteLine(da.GetEnd());
        */
    }

    public class MyClass
    {
        private const int MAX = 10;
        private string name;
        private int[] data = new int[MAX];
        // indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                //if (!(index < 0 || index >= MAX))
                if (index >= 0 && index < MAX)
                {
                    data[index] = value;
                }
            }
        }
        public void SetData(int index, int value)
        {
            if (index >= 0 && index < MAX)
            {
                data[index] = value;
            }
        }
        public int GetData(int index)
        {
            if (index >= 0 && index < MAX)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        int id = 0;
        public string Name { set; get; }
        public void Run(int id) { }
        protected void Execute() { }
    }

    public void IndexerTest()
    {
        MyClass cls = new MyClass();
        cls[1] = 1024;
        int i = cls[1];
        Console.WriteLine(i);
        cls.SetData(3, 100);
        int i2 = cls.GetData(3);
        Console.WriteLine(i2);

        cls.Name = "Lee";
        string str = cls.Name;
        cls.Run(13);
    }

    class ClassA
    {
        #region Public methods
        public void Run() { }
        public void Create() { }
        #endregion Public methods

        #region Property
        public int Id { get; set; }
        #endregion Property

        #region Privates
        void Execute() { }
        #endregion
    }
    public void PreProTest()
    {
        bool verbose = false;
#if (TEST_ENV)
        Console.WriteLine("Now test env.");
        verbose = true;
#elif (PROD_ENV)
        Console.WriteLine("Now prod env.");
#else
        Console.WriteLine("???");
#endif
        if (verbose)
        {
            Console.WriteLine("Verbose...");
        }
    }

    class MyLesson
    {
        public event EventHandler Run;
        public void RunEvent()
        {
            if (Run != null)
            {
                Run(this, EventArgs.Empty);
            }
        }
    }

    public void EventTest()
    {
        MyLesson lesson = new MyLesson();
        lesson.Run += new EventHandler(Lesson1);
        lesson.Run += new EventHandler(Lesson2);
        lesson.RunEvent();
        lesson.Run -= new EventHandler(Lesson1);
        lesson.RunEvent();
        //lesson.Run += new EventHandler(Lesson3);
    }
    public void Lesson3()
    {
        //
    }
    public void Lesson2(object sender, EventArgs e)
    {
        Console.WriteLine("second...");
    }
    public void Lesson1(object sender, EventArgs e)
    {
        Console.WriteLine("first...");
    }

    public void StringTest()
    {
        string s21 = "string";
        Console.WriteLine(s21.IndexOf('r'));
    }

    public void StandardNumericFormatString()
    {
        Console.WriteLine("C Example {0:C}", 123.456f);
        Console.WriteLine("D6 sample {0:D6}", -1234);
        Console.WriteLine("{0:E2}", -1052.0329112756f);
        Console.WriteLine("{0:F4}", -1234.56f);
        Console.WriteLine("{0:N3}", -1234.56f);
        Console.WriteLine("{0:P1}", -0.39678f);
        Console.WriteLine("{0:X4} {1:X4}", 255, -1);
    }

    public void ParamSample()
    {
        // ref. 초기화 필요
        int x = 1;
        double y = 1.0;
        double ret = GetData(ref x, ref y);
        Console.WriteLine($"x={x},y={y:0.0},ret={ret:0.0}");
        Console.WriteLine("x={0},y={1:0.0},ret={2:0.0}", x, y, ret);
        // out
        int c, d;
        bool bret = GetData(10000, 2000, out c, out d);
        Console.WriteLine($"c={c:#,#}:d={d:#,#}:bret={bret}");
        Console.WriteLine("c={0:#,#}:d={1:#,#}:bret={2}", c, d, bret);

        Method1(26, 100, "Park");
        Method1(name: "John", age: 10, score: 90);
        Method1(score: -20, name: "Lee", age: 30);
        Method1(2, 40);
        Method1(score: 7, age: 10);
        Method2(100, 0, 44);
        Method2(99);
        Method3(44, 80, true);
        Method3();
        Method3(live: false);
        Method3(score: 100, age: 10);

        int ret2 = Util.Calc(1, 2);
        ret2 = Util.Calc(100, 20, "-");
        ret2 = Util.Calc(b: 4, a: 3, calcType: "*");
        ret2 = Util.Calc(b: 4, a: 3);

        int s = Calc2(1, 2, 3, 4);
        //int s2 = Calc3(1, 2, 3, 4);
        int s2 = Calc2(6, 7, 8, 9, 0, 1);
    }

    public int Calc3(int[] values)
    {
        return 0;
    }
    public int Calc2(params int[] values)
    {
        return 0;
    }

    public void Method3(int age = 10, int score = 0, bool live = true)
    {

    }
    public void Method2(int age, int score = 100, int city = 11)
    {

    }
    public void Method1(int age, int score, string name = "NoName")
    {

    }

    public double GetData(ref int a, ref double b)
    {
        return ++a * ++b;
    }

    public bool GetData(int a, int b, out int c, out int d)
    {
        c = a + b;
        d = a - b;
        return true;
    }

    public int Calculate(int a)
    {
        Console.WriteLine("a=" + a);
        a *= 2;
        Console.WriteLine("a=" + a);
        return a;
    }

    #region Nullable
    public void NullableTest()
    {
        int? a = null;
        int? b = 0;
        int result = Nullable.Compare<int>(a, b);
        Console.WriteLine(result);

        double? c = 0.01;
        double? d = 0.0100;
        bool result2 = Nullable.Equals<double>(c, d);
        Console.WriteLine(result2);
    }
    #endregion

    double _Sum = 0;
    DateTime _Time;
    bool? _Selected;

    public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
    {
        if (i.HasValue && d.HasValue)
        {
            this._Sum = (double)i.Value + (double)d.Value;
        }
        if (!time.HasValue)
        {
            throw new ArgumentException();
        }
        else
        {
            this._Time = time.Value;
        }
        // 만약 selected가 null이면 false를 할당
        // if (selected == null)
        // {
        //     this._Selected = false;
        // }
        // else
        // {
        //     this._Selected = selected;
        // }
        this._Selected = selected ?? false;
    }

    public void ClassTest()
    {
        MyCustomer mc = new MyCustomer();
        mc.Name = "Kim";
        mc.Age = 20;
        //mc.SetAge(-3);
        Console.WriteLine(mc.GetCustomerData());
        Console.WriteLine(mc.CalAge(30));
    }

    // 구조체 정의
    public struct MyPoint
    {
        public int X;
        public int Y;
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }

    public void StructTest()
    {
        //CSStudy.MyPoint pt = new CSStudy.MyPoint(10, 12);
        var pt = new MyPoint(10, 12);
        var pt2 = new MyPoint();
        Console.WriteLine(pt.ToString());
        Console.WriteLine(pt2.ToString());
    }

    public void ExceptionSample()
    {
        int[] intArr = new int[3];
        try
        {
            intArr[0] = 0;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("AE ...");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("ior 오류 발생!");
        }
        finally
        {
            Console.WriteLine("에러 없음");
        }
    }

    public void LoopSample()
    {
        // for
        for (int i = 0; i < 10; i += 3)
        {
            //Console.WriteLine("Loop {0}", i);
        }
        // foreach
        string[] array = new string[] { "AB", "CD", "EF" };
        // foreach (string s in array)
        // {
        //     Console.WriteLine(s);
        // }
        foreach (var item in array)
        {
            //Console.WriteLine(item);
        }

        string[,,] arr = new string[,,]{
            {{"1", "2"}, {"11", "22"}},
            {{"3", "4"}, {"33", "44"}}
        };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    //Console.Write(arr[i, j, k] + ",");
                }
            }
        }
        //Console.WriteLine();
        foreach (var item in arr)
        {
            //Console.Write(item + ",");
        }
        // while
        int answer = 6;
        while (answer <= 10)
        {
            Console.Write(answer + ",");
            answer++;
        }
        Console.WriteLine();
        answer = 6;
        // do~while
        do
        {
            Console.Write(answer + ",");
            answer++;
        } while (answer <= 10);
    }

    public void ConditionSample()
    {
        string category = "참외"; //"사과";
        int price = 0;

        switch (category)
        {
            case "참외":
            case "사과":
                price = 2000;
                break;
            case "딸기":
                price = 10000;
                break;
            case "포도":
                price = 6000;
                break;
            default:
                price = 1000;
                break;
        }
        // 사과는 2000원입니다.
        Console.WriteLine("{1}는 {0}원입니다.", price, category);

        int val = 100;
        switch (val)
        {
            case 0:
                // 0...
                break;
            case 100:
                // 100...
                break;
            default:
                break;
        }
    }

    public void OperatorSample()
    {
        int i = 100, j = 0;
        Console.WriteLine("before:{0}-{1}", i, j);
        //j = i--;
        j = --i;
        Console.WriteLine("after:{0}-{1}", i, j);

        for (int z = 0; z < 10; ++z)
        {

        }
        int a = 5, b = -2, c = 1;
        bool d = true; //false;
        if ((a > 1 && b < 0) || c == 1 || !d)
        {
            Console.WriteLine("ok");
        }

        byte ba = 7;
        byte bb = (byte)((ba & 3) | 4);
        Console.WriteLine(bb);

        i = 2;
        i = i << 5;

        //int val = (a > b) ? a : b;
        int val;
        if (a > b)
        {
            val = a;
        }
        else
        {
            val = b;
        }
        string str = null;
        string s = str ?? "몰라";
        Console.WriteLine(s);

        int? ni = null;
        i = ni ?? 20;
    }

    string GetName() { return ""; }
    static public int GetId() { return 0; }
    public static int GetId2() { return 0; }

    public void CodingGuide()
    {
        bool isValid = false;
        if (isValid == false)
        {
            // 하지마라
        }
        else
        {
            // 해라
        }
        if (isValid)
        {
            // 해라
        }
        else
        {
            // 하지마라
        }

        int a = 0, b = 0;
        if ((a = b) == 10)
        {

        }
        a = b;
        if (a == 10)
        {

        }

        string path = @"C:\Temp\Test.txt";
        string s1 = "1", s2 = "2", s3 = "3";
        //var res = s1 + "+" + s2 + "=" + s3;
        var res = string.Format("{0}+{1}={2}", s1, s2, s3);
    }

    public enum GameState { Ready, Run }
    public enum Category
    {
        Cake,
        IceCream,
        Bread
    }
    enum City
    {
        Seoul,
        Daejun,
        Busan = 5,
        Jeju = 10
    }
    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }

    public void EnumSample()
    {
        Category cafeCategory;
        cafeCategory = Category.Bread;
        //Console.WriteLine((int)cafeCategory);
        City myCity = City.Seoul;
        int cityValue = (int)myCity;
        if (myCity == City.Seoul)
        {
            //Console.WriteLine("Welcome to Seoul");
        }

        // OR 연산자로 다중 플래그 할당
        Border b = Border.Top | Border.Bottom | Border.Left;
        // & 연산자로 플래그 체크
        if ((b & Border.Top) != 0)
        {
            // HasFlag() 이용
            if (b.HasFlag(Border.Bottom))
            {
                Console.WriteLine((int)b);
            }
        }
    }

    public void SBSample()
    {
        var sb = new StringBuilder();
        for (int i = 1; i <= 26; i++)
        {
            sb.Append(i.ToString());
            //sb.Append(System.Environment.NewLine);
            sb.Append(' ');
        }
        string s = sb.ToString();
        Console.WriteLine("Result:{0}", s);

        sb.Clear();
        sb.Append((char)('A' + 3));
        Console.WriteLine(sb.ToString());
    }

    public void ASCIISample()
    {
        string s = "C# Studies";
        for (int i = 0; i < s.Length; i++)
        {
            //Console.WriteLine("{1}: {0}", i, s[i]);
        }
        string str = "Hello";
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            //Console.WriteLine("{0}:{1}", i, charArray[i]);
        }
        char[] charArray2 = { 'A', 'B', 'C', 'D' };
        string s2 = new string(charArray2);
        //Console.WriteLine(s2);
        // 문자 연산
        char c1 = 'Z';
        char c2 = (char)(c1 - 9);
        Console.WriteLine(c2);
    }

    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programming";
        int startIndex = 3;
        int len = s2.Length - startIndex - 1;
        string s3 = s2.Substring(startIndex, len);
        Console.WriteLine(s3);

        char c1 = 'A';
        char c2 = 'B';

        string s4 = s1 + " " + s2;
        Console.WriteLine("String: {0}", s4);

        string s4sub = s4.Substring(1, 5);
        Console.WriteLine("SubString: {0}", s4sub);
    }

    public void ArraySample()
    {
        var players = new string[10];
        string[] regions = { "서울", "경기", "부산" };

        var depts = new string[,] { { "김과장", "경리부" }, { "이과장", "총무부" } };

        string[,,] cubes;

        int[,] aa = new int[3, 2];
        int[][] A = new int[3][];
        A[0] = new int[2];
        A[1] = new int[3] { 1, 2, 3 };
        A[2] = new int[4] { 1, 2, 3, 4 };
        A[0][0] = 1;
        A[0][1] = 2;
        aa[0, 0] = 1;
        aa[0, 1] = 2;
        aa[2, 1] = 3;
        Console.WriteLine(A.GetLength(0));
        Console.WriteLine(A[1].Length);
        int sum = 0;
        int[] scores = { 80, 78, 60, 90, 100 };
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        //Console.WriteLine("sum = " + sum);
        //Console.WriteLine("sum = {0}", sum);
        Console.WriteLine($"sum = {sum}");
    }


    public void SortedDicSample()
    {
        var tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1003, "John");
        tmap.Add(1010, "Irina");
        tmap.Add(1005, "Lee");
        tmap.Add(1200, "Kim");

        string name1010 = tmap[1010];

        // Iterator
        foreach (KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{2}{0}:{1} {4}", kv.Key, kv.Value, "*", 3, kv);
        }
    }

    public void HashTableSample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina SP");
        ht.Add("tom", "Tom Cr");
        ht.Add(3, 'a');

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }

        //Dictionary<int, string> emp = new Dictionary<int, string>();
        var emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        //emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        if (emp.ContainsKey(1002) == false)
        {
            emp.Add(1002, "Kim");
        }

        string name = emp[1002];
        Console.WriteLine(name);
    }

    public void StackQueue()
    {
        //Stack<float> s = new Stack<float>();
        var s = new Stack<float>();
        s.Push(10.5f);
        s.Push(3.54f);
        s.Push(4.22f);

        float pp = s.Peek();
        Console.WriteLine("pp=" + pp);

        var p3 = s.Pop();
        Console.WriteLine("p3=" + p3);

        var p4 = s.Pop();
        Console.WriteLine("p4=" + p4);

        Queue<int> q = new Queue<int>();
        q.Enqueue(120);
        q.Enqueue(130);
        q.Enqueue(150);

        int next = q.Peek();
        Console.WriteLine("next=" + next);

        next = q.Dequeue();
        Console.WriteLine("next=" + next);
    }

    public void LinkedListSample()
    {
        //LinkedList<string> list = new LinkedList<string>();
        var list = new LinkedList<string>();

        int a = 1, b = 2;
        // var는 한줄에 하나만 정의 가능
        //var va = 1, v2 = 2;

        list.AddLast("Apple");
        list.AddLast("Banana");
        list.AddLast("Lemon");

        //LinkedListNode<string> node = list.Find("Banana");
        var node = list.Find("Banana");
        var newNode = new LinkedListNode<string>("Grape");

        list.AddAfter(node, newNode);
        list.AddAfter(node, "Kiwi");

        list.ToList<string>().ForEach(p => Console.WriteLine(p));

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public void ListSample()
    {
        //List<int> myList = new List<int>();
        var myList = new List<int>();
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = myList[1];

        var chrList = new List<char>();
        chrList.Add('b');

        var boolList = new List<bool>();
        boolList.Add(false);

        var iarray = new int[100];
        iarray[2] = 10;
        myList.Add(10);
        Console.WriteLine(iarray.Length);
        Console.WriteLine(myList.Count);

        // 정렬
        myList.Sort();
    }

    public void ArrayListSample()
    {
        //ArrayList myList = new ArrayList();
        var myList = new ArrayList();
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = (int)myList[1];
        Console.WriteLine(val);
        Console.WriteLine(myList[0]);
    }

    public void ArrayExample()
    {
        int sum = 0;
        //int[] nums = new int[10] { 1,2,3,4,5,6,7,9,8,0 };
        int[] nums = new int[10];

        nums[0] = 1;
        nums[1] = 2;
        //
        nums[9] = 0;
        // 이거 안됨!!!
        //nums[10] = 9;

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
        }

        for (int i = 0; i < nums.Length; i += 1)
        {
            Console.WriteLine(i + " : " + nums[i]);
            sum += nums[i];
        }

        Console.WriteLine("sum=" + sum);
    }

    /// <summary>
    /// int, float, string 은 기억하자
    /// </summary>
    public void DataType()
    {
        // bool 타입
        bool b = true;

        short sh = -32768;
        int i = 2147483647;
        long l = 1234L;
        float f = 123.85f;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        Console.WriteLine(f);
        i = (int)f;
        Console.WriteLine(i);

        char c = 'A';
        string s = "H";
        // null과 ""는 다르다
        string s2 = null;
        string s3 = "";
        string s4 = string.Empty;

        // 이건 에러난다
        //int ii = null;

        DateTime dt = new DateTime(2025, 7, 9, 11, 16, 00);

        if (i > int.MaxValue)
        {

        }
    }
}