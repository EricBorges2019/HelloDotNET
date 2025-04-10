using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter which Fibonacci Number you want printed: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            Console.WriteLine($"The {n}th Fibonacci number is: {Fibonacci(n)}");
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
        }
    }

    public static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }
}