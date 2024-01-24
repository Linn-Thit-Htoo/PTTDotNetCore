public class Animal // base class or parent class or super class
{
    public string animalName = "Aimal Name";
    private int age = 10;
    protected string color = "white"; // cannot be accessed directly

    public void Eat() => Console.WriteLine("Animal is eating...");
}

public class Dog : Animal // derived class or child class or sub class
{
    public string GetColor() // getter
    {
        return color;
    }
}

public class Program
{
    public string Name = "Leo";
    private int UserID = 10;
    protected string Email = "linnthit77387@gmail.com";

    public Program() // constructor
    {
        Console.WriteLine("Constructor is executed!");
    }

    public static void Main(string[] args)
    {
        //Program program = new();
        //program.Greeting();

        //Program.PrivateMethod();

        Dog dog = new();
        dog.Eat();
        Console.WriteLine(dog.GetColor());

        Console.ReadKey();
    }
    public void Greeting() => Console.WriteLine("Hello User!"); // shorthand for method

    private static void PrivateMethod() => Console.WriteLine("This is private method!");
}