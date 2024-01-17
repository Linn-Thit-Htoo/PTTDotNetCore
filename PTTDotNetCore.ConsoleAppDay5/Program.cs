public class Program
{
    public static void Main(String[] args)
    {
        //int num = 5;

        //for(int i = 0; i < num; i++)
        //{
        //    if (i == 3) break;
        //    Console.WriteLine(i);
        //}

        //for(int i = 0; i < num; i++)
        //{
        //    if (i == 3) continue;
        //    Console.WriteLine(i);
        //}

        //string name = "Linn" + " Thit"; // concatenate
        //Console.WriteLine($"\nYour name is: {name}"); // interpolate `${}`

        //int index = name.LastIndexOf('T'); // get the index of T
        //Console.WriteLine(name.Substring(index)); // start index, end index (without end index, end of string)

        do
        {
            Console.WriteLine("Enter your email: ");

            if (IsNull(Console.ReadLine())) Console.WriteLine("Email field is required.");

            else break;

        } while (true);


        do
        {
            Console.WriteLine("Enter your password: ");

            if (IsNull(Console.ReadLine())) Console.WriteLine("Password field is required.");

            else break;

        } while (true);
    }
    public static bool IsNull(string str)
    {
        return string.IsNullOrEmpty(str);
    }
}