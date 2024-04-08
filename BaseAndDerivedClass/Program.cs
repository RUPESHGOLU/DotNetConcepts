//try
//{
BaseClass baseClass = new DerivedClass();
baseClass.Method1();
Console.WriteLine(StaticClass.Value);
//}
//catch(Exception ex)
//{

//}

public interface IInterface
{
    void Method1();
}

public class BaseClass : IInterface
{
    public BaseClass()
    {
        Console.WriteLine("Base Class Constructor, Value = {0}", StaticClass.Value);
        StaticClass.Value++;
    }

    static BaseClass()
    {
        Console.WriteLine("Base Class Static Constructor, Value = {0}", StaticClass.Value);
        StaticClass.Value++;
    }

    public virtual void Method1()
    {
        Console.WriteLine("Base Class Method, Value = {0}", StaticClass.Value);
        StaticClass.Value++;
    }
}
public class DerivedClass : BaseClass
{
    public DerivedClass()
    {
        Console.WriteLine("Derived Class Constructor, Value = {0}", StaticClass.Value);
        StaticClass.Value++;
    }
    static DerivedClass()
    {
        Console.WriteLine("Derived Class Static Constructor, Value = {0}", StaticClass.Value);
        StaticClass.Value++;
    }

    public override void Method1()
    {
        try
        {
            Console.WriteLine("Derived Class Method, Value = {0}", StaticClass.Value);
            StaticClass.Value++;
            var a = StaticClass.Value / 0;
        }
        catch
        {
            throw;
        }
        finally
        {
            try
            {

            }
            catch
            {
            }


        }
    }
}

public static class StaticClass
{
    public static int Value = 10;
}



