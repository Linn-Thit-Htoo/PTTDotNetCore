public class Program
{
    public static int count = 0;
    public Program()
    {
        Console.WriteLine("Constructor executed!");
    }
    public void SetCount()
    {
        count += 1;
    }
    public int GetCount()
    {
        return count;
    }
    public static void Main(string[] args)
    {
        Program program = new(); // instance
        program.SetCount();

        Console.WriteLine(program.GetCount()); // 1

        Program program1 = new();
        program1.SetCount();

        Console.WriteLine(program.GetCount());
    }
}