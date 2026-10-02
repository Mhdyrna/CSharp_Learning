using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            sum += a;

            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine("\n Sum: " + sum);

    }
}
