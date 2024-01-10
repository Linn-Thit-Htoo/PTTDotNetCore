using System.Data;

public class Program
{
    public static void Main(string[] args)
    {
        int result1 = Sum(1, 2);

        int result2 = Sum(10, 20);

        Console.WriteLine("Result is: " + result2);

        // assignment operators
        int num1 = 10; // assign

        //num1 = num1 + 1;
        num1 += 1; // num1++
        num1 -= 1; // num1 = num1 -1
        num1 *= 2; // num1 = num1 *2
        num1 /= 2; // num1 = num1 / 2
        num1 %= 2; // num1 = num1 % 2

        int num2 = 10;

        //Console.WriteLine(num2.GetType());
        //Console.WriteLine(num2 != 5);
        //Console.WriteLine(num2 > 5);
        //Console.WriteLine(num2 <= 10);

        Console.WriteLine("Please enter password: ");
        string? password = Console.ReadLine();

        // default value of string is ""
        if (password == "")
        {
            Console.WriteLine("Password filed is requierd!");
        }
        else
        {
            if (password == "123123")
            {
                Console.WriteLine("Login Success!");
            }
            else
            {
                Console.WriteLine("Login Fail!");
            }
        }
    }

    // sum
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}