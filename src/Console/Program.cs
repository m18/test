namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine($"3 + 5 = {new Calc().Add(3, 5)}");
        }
    }
}