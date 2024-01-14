using System;

public class Program
{
    public static int result = 0;
    public static string str;
    public static int x;
    public static int y;

    public static void Main(string[] args)
    {
        Console.WriteLine("CALCULATION");

        do
        {
            Console.WriteLine("Enter a first number:");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Please fill valid number");
            }

            Console.WriteLine("Enter a second number:");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Please fill valid number");
            }

            result = Sum(x, y);
            Console.WriteLine("The sum of two numbers: " + result);
            result = Sub(x, y);
            Console.WriteLine("The sub of two numbers: " + result);
            result = Mul(x, y);
            Console.WriteLine("The mul of two numbers: " + result);
            result = Div(x, y);
            Console.WriteLine("The div of two numbers: " + result);

            Console.WriteLine("Do you want to solve (yes/no)?");
            str = Console.ReadLine().ToLower();

        } while (str != "no");
        Console.ReadKey();
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static int Sub(int a, int b)
    {
        return a - b;
    }
    public static int Mul(int a, int b)
    {
        return a * b;
    }
    public static int Div(int a, int b)
    {
        return a / b;
    }

}