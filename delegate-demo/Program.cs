public delegate void Delegate(string msg); // declaring a delegate

class Program
{
    static void Main(string[] args)
    {
        Delegate del = ClassA.MethodA;
        del("Hello World");

        del = ClassB.MethodB;
        del("Hello World");

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del("Hello World");
        Console.ReadLine();
    }
}

public class ClassA
{
    public static void MethodA(string msg)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + msg);
    }
}

public class ClassB
{
    public static void MethodB(string msg)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + msg);
    }
}