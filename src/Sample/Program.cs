using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine($"3 + 5 = {new Calc().Add(3, 5)}");
    }
}
