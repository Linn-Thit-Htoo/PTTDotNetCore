public class Program
{
    public static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        #region switch statement
        switch (month)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("Sepemtember");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Invalid!");
                break;
        }
        #endregion

        // when to use for loop => know the endpoint
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        //string password = "123123";

        //while (true)
        //{
        //    Console.WriteLine("Please enter your password: ");
        //    string? passwordInput = Console.ReadLine();

        //    if (passwordInput == password)
        //    {
        //        Console.WriteLine("Success!");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fail!");
        //    }
        //}

        //int option = 0;

        //do
        //{
        //    Console.WriteLine("Please choose 3 options: 1 for your name, 2 for your email & 3 for exit");
        //    option = Convert.ToInt32(Console.ReadLine());

        //    switch (option)
        //    {
        //        case 1:
        //            Console.WriteLine("Linn Thit\n");
        //            break;
        //        case 2:
        //            Console.WriteLine("lth1212001@gmail.com\n");
        //            break;
        //        case 3:
        //            option = 3;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid option!\n");
        //            break;
        //    }
        //} while (option != 3);

        int[] nums = { 1, 2, 3, 4, 5 };

        List<string> students = new()
        {
            "Linn Thit",
            "Leo"
        };

        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }

        //foreach (string student in students)
        //{
        //    Console.WriteLine(student);
        //}

        //students.ForEach((student) =>
        //{
        //    Console.WriteLine(student);
        //});

        students.ForEach(student => Console.WriteLine(student)); // lambda expression

        Console.ReadKey();
    }
}