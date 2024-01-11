//As we know abstract class cannot be initialize and it will throw a compile time exception
//AbstractClass abstractClassObject = new AbstractClass();

//We are going to initialize derived class and it will call parent constructor and it is known as constructor chaining.
SecondDerivedClass secondDerivedClassObject = new();
secondDerivedClassObject.Print();
FirstDerivedClass derivedClassObject = new();
derivedClassObject.Print();
public abstract class AbstractClass
{
    public AbstractClass()
    {
        Console.WriteLine("Inside Abstract Class Default Constructor");
    }
    static AbstractClass()
    {
        Console.WriteLine("Inside Abstract Class Static Constructor");
    }
    public abstract void Print();
}

public class FirstDerivedClass : AbstractClass
{
    public FirstDerivedClass()
    {
        Console.WriteLine("Inside Derived Class Default Constructor");
    }
    static FirstDerivedClass()
    {
        Console.WriteLine("Inside Derived Class Static Constructor");
    }
    public override void Print()
    {
        Console.WriteLine("Inside Derived Class Overrriden Method");
    }
}
public class SecondDerivedClass : FirstDerivedClass
{
    static int staticNumber;

    public SecondDerivedClass()
    {
        staticNumber++;
        Console.WriteLine("Inside SecondDerivedClass Default Constructor");
    }
    static SecondDerivedClass()
    {
        Console.WriteLine("Inside SecondDerivedClass Static Constructor");
    }
    public override void Print()
    {
        Console.WriteLine("Inside SecondDerivedClass Overrriden Method");
    }
}