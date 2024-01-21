using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int resultInt = calculator.Add(5, 10);
        Console.WriteLine("Adding integers: 5 + 10 = " + resultInt);


        double resultDouble = calculator.Add(3.5, 7.2);
        Console.WriteLine("Adding doubles: 3.5 + 7.2 = " + resultDouble);


    }
}