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