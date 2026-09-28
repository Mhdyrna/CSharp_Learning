using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        int firstnumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        int secondnumber = int.Parse(Console.ReadLine());

        if (firstnumber % secondnumber == 0)
        {
            Console.WriteLine($"{firstnumber}%{secondnumber} is equal zero");
        }
        else
        {
            Console.WriteLine($"{firstnumber}%{secondnumber} is not equal zero");
        }
        if(firstnumber%3==0)
        {
            Console.WriteLine("First number can be devided by 3");
        }
        else
        {
            Console.WriteLine("First number can not be devided by 3");
        }
           Console.Write("Enter Another Number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool isPrime = true;

            if (firstnumber < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
