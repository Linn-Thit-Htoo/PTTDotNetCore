using System;


public class Program
{
    public static int firstNum;
    public static int secNum;

    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Enter first number: ");
            if (int.TryParse(Console.ReadLine(), out int firstNum))
            {
                Program.firstNum = firstNum;
                break;
            }
            else
            {
                Console.WriteLine("Invalid first number!\n");
            }
        }

        while (true)
        {
            Console.WriteLine("Enter second number: ");
            if (int.TryParse(Console.ReadLine(), out int secNum))
            {
                Program.secNum = secNum;
                break;
            }
            else
            {
                Console.WriteLine("Invalid second number!\n");
            }
        }
        int operators = 0;
        do
        {
            Console.WriteLine("Choose one operators: ");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. Exit");
            operators = Convert.ToInt32(Console.ReadLine());

            switch (operators)
            {
                case 1:
                    Console.WriteLine($"\nResult: {firstNum + secNum}\n");
                    break;
                case 2:
                    Console.WriteLine($"\nResult: {firstNum - secNum}\n");
                    break;
                case 3:
                    Console.WriteLine($"\nResult: {firstNum * secNum}\n");
                    break;
                case 4:
                    Console.WriteLine($"\nResult: {firstNum / secNum}\n");
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        } while (operators != 5);

    }
    public static void Day2()
    {
        int a; // initialization default 0
        a = 10; // assign
        a = 20; // re-assign || override
        Console.WriteLine(a);

        string name = "Leo";
        Console.WriteLine(name);

        // camelCase 
        string firstName = "Linn Thit";
        string lastName = "";

        Console.WriteLine("Last name is: " + lastName);

        char firstChar = 'A'; // char data type

        Console.ReadLine();
    }
}