public class ClimateMonitor
{
    ILogger logger;
    public ClimateMonitor(ILogger inlogger)
    {
        logger = inlogger;
    }
    public void Start()
    {
        while (true)
        {
            Console.Write("온도를 입력해주세요 : ");
            string temp = Console.ReadLine();
            if (temp == "") break;
            logger.WriteLog($"현재 온도 : {temp}");
        }
    }
}

public interface ILogger
{
    void WriteLog(string message);
}

public class FileLogger : ILogger
{
    StreamWriter writer;
    public FileLogger(string path)
    {
        writer = File.CreateText(path);
        writer.AutoFlush = true;
    }
    public void WriteLog(string message)
    {
        writer.WriteLine(
            $"{DateTime.Now.ToShortTimeString()} {message}");
    }
}
public class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine
            ($"{DateTime.Now.ToLocalTime()}, {message}");
    }
}

public interface IComparable
{
    int CompareTo(object obj);
    void Open();
    void Close();
}

public class MyClass2 : IComparable
{
    public int CompareTo(object obj)
    {
        return 0;
    }
    public void Open() { }
    public void Close() { }
}

public class InterfaceSample
{
    public void Sample()
    {
        //IComparable ic = new IComparable(); // 이건 에러
        IComparable ic = new MyClass2();
        ic.Open();
        ic.Close();

        MyClass2 mc2 = new MyClass2();
        mc2.Open();
        mc2.Close();
    }
}

public static class MyUtility
{
    static int ver;
    static MyUtility()
    {
        ver = 1;
    }
    public static string Convert(int i)
    {
        return i.ToString();
    }
    public static int ConvertBack(string s)
    {
        return int.Parse(s);
    }
}

public class MyClass
{
    int val = 1;

    public MyClass()
    {
        val = 100;
    }

    // 보통 메서드
    public int InstRun()
    {
        int k = Run();
        return val;
    }

    // static method
    public static int Run()
    {
        //InstRun();  //에러
        //return val; //에러
        return 1;
    }
}

public class Client
{
    public void Test()
    {
        // 일반 메서드 호출
        MyClass myClass = new MyClass();
        int i = myClass.InstRun();
        Console.WriteLine($"i: {i}");
        // static
        int j = MyClass.Run();
        Console.WriteLine($"j: {j}");
    }
}

// base class
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    protected int Weight { get; set; }
    private int Gold;
    public void SetGold(int value)
    {
        Gold = value;
    }
    public int GetGold()
    {
        return Gold;
    }
}

// child class
public class Dog : Animal
{
    public void SetWeight(int value)
    {
        Weight = value;
    }

    public void HowOld()
    {
        // base class Age
        //Console.WriteLine("Age: {0}", this.Age);
        Console.WriteLine($"Age: {this.Age}, Weight: {this.Weight}");
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{this.Name} is flying");
    }
}

public abstract class PureBase
{
    // abstract 
    public abstract int GetFirst();
    public abstract int GetNext();
    public int GetEnd()
    {
        return 100;
    }
}

public class DerivedA : PureBase
{
    private int no = 1;
    // override
    public override int GetFirst()
    {
        return no;
    }
    public override int GetNext()
    {
        return ++no;
    }
}