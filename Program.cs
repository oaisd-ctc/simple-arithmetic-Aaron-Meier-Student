using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is X?");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("What is Y?");
        float y = float.Parse(Console.ReadLine());
        Console.WriteLine("What opperation do you want to do? + - * / %");
        string opperator = Console.ReadLine();
        double result = 0;
        if (opperator == "+") {
            result = x+y;
        } else if (opperator == "-") {
            result = x-y;
        } else if (opperator == "*") {
            result = x*y;
        } else if (opperator == "/") {
            result = x/y;
        } else if (opperator == "%") {
            result = x%y;
        }
        Console.WriteLine(result);
    }
}
