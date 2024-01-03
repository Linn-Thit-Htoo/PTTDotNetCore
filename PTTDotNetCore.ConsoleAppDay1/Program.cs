namespace PTTDotNetCore.ConsoleAppDay1
{
    public class Program
    {
        public static void Main(string[] args) // main method which is the entry point of the program.
        {
            
            Greeting();

            Console.ReadKey(); // if found any key, the program will be stopped.
        }
        public static void Greeting()
        {
            Console.WriteLine("Hello User!");
        }
    }
}
