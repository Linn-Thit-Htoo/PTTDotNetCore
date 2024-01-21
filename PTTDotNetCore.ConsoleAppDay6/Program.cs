public class Program
{
    public static string name { get; set; }
    public static void Main(string[] args)
    {
        Program.name = "Linn Thit";
        Program program = new();
        Console.WriteLine(program.GetName());

        Console.WriteLine("Sum: " + program.Sum(1.5, 2.5));


        List<string> lst = new()
        {
            "1",
            "Leo",
            "PTT"
        };

        lst.ForEach(x => Console.WriteLine(x));

        //lst.ForEach(item =>
        //{
        //    Console.WriteLine(item);
        //});
        //foreach(string item in lst) Console.WriteLine(item);

        Console.ReadKey();
    }

    // void method
    public void Greeting()
    {
        Console.WriteLine("Helo User!");
    }

    // int return type method
    public int Sum(int firstNum, int secNum)
    {
        return firstNum + secNum;
    }

    public double Sum(double firstNum, double secNum)
    {
        return firstNum + secNum;
    }

    public int Sum(int firstNum, int secNum, int thirdNum)
    {
        return firstNum + secNum + thirdNum;
    }

    // bool return type
    public bool IsNull(string str)
    {
        return string.IsNullOrEmpty(str);
    }

    // string return type
    public string GetName()
    {
        return Program.name;
    }
}