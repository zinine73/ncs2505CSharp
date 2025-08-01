public class MyCustomer
{
    // 필드
    private string name;
    private int age;
    // 이벤트
    public event EventHandler NameChanged;
    // 생성자 (constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }
    // 프로퍼티
    public string Name
    {
        get
        {
            Console.WriteLine("이름을 넘기겠습니다");
            return this.name;
        }
        set
        {
            this.name = value;
            if (NameChanged != null)
            {
                NameChanged(this, EventArgs.Empty);
            }
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("음수값은 안되요");
            }
            else
            {
                this.age = value;
            }
        }
    }
    public void SetAge(int value)
    {
        if (value < 0)
        {
            Console.WriteLine("음수값은 안되요");
        }
        else
        {
            age = value;
        }
    }
    // 메서드
    public string GetCustomerData()
    {
        /*
        string data =
            string.Format("Name:{0} (Age:{1})",
            Name, Age);
        */
        string data = $"Name:{Name} (Age:{Age})";
        return data;
    }

    public int CalAge(int val)
    {
        Age = Age - val;
        return Age;
    }
}