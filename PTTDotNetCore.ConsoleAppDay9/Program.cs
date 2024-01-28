#region Polymorphism
//class Animal  // Base class (parent) 
//{
//    public virtual void animalSound()
//    {
//        Console.WriteLine("The animal makes a sound");
//    }
//}

//class Pig : Animal  // Derived class (child) 
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("The pig says: wee wee");
//    }
//}

//class Dog : Animal  // Derived class (child)
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("The dog says: bow wow");
//    }
//}

//public class Program
//{
//    public static void Main(String[] args)
//    {
//        Animal pig = new Pig();
//        pig.animalSound();

//        Animal dog = new Dog();
//        dog.animalSound();
//    }

//    public int Sum(int x, int y)
//    {
//        return x + y;
//    }

//    public double Sum(double x, double y)
//    {
//        return x + y;
//    }
//    public int Sum(int x, int y, int z)
//    {
//        return x + y + z;
//    }
//}
#endregion

#region Encapsulation
public class Animal
{
    private string _name;

    //public Animal(string name)
    //{
    //    // this => Animal animal = new Animal();
    //    // cannot use this in static method
    //    this._name = name;
    //}

    public string GetName()
    {
        return this._name;
    }

    public void SetName(string name = "Aung Net")
    {
        this._name = name;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new();
        animal.SetName("tester");
        string animalName = animal.GetName();
        Console.WriteLine(animalName);
    }
}
#endregion