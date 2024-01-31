#region Abstraction
//public abstract class Animal
//{
//    public abstract void animalSound();

//    // regular method
//    public void sleep() => Console.WriteLine("Animal is sleeping...");
//}

//public class Dog : Animal
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("Dog is making a sound...");
//    }
//}

//public class Cat : Animal
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("Cat is making a sound...");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Dog dog = new();
//        dog.animalSound();
//        dog.sleep();
//    }
//}
#endregion

#region Interface
public interface IWorker
{
    void Work();
    void Rest();

    void Sleep();
}
public class HumanWorker : IWorker
{
    public void Rest()
    {
        Console.WriteLine("Human worker is resting...");
    }

    public void Sleep()
    {
        Console.WriteLine("Human worker is sleeping...");
    }

    public void Work()
    {
        Console.WriteLine("Human worker is working...");
    }
}

public class RobotWorker : IWorker
{
    public void Rest()
    {
        
    }

    public void Sleep()
    {
        
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
#endregion