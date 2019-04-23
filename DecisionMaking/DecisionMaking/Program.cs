using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;


            Console.Write("What is your name?  ");
            name = Console.ReadLine();

        beginning_label:

            Console.Write($"\n\nHello {name}, enter a number between 1 and 100?  ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("\n\n");
                if (number > 0 && number < 101)
                {
                    //Did not test if odd number is above 60, since the output is the same as numbers below 60
                    if (number % 2 != 0)
                    {
                        Console.WriteLine($"The number {number} is Odd.\n\n");
                    }
                    else if (number > 25 && number <= 60)
                    {
                        Console.WriteLine("Even.\n\n");
                    }
                    else if (number < 26)
                    {
                        Console.WriteLine("Even and less than 25.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"The number {number} is even.\n\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n\n\a{name}, the number has to be between 1 and 100, inclusive.\n\n");
                }
            }
            else
            {
                Console.WriteLine($"\n\n\aOh no {name}, {number} is not a valid input....try again.\n\n");
            }

            Console.Write("Do you want try it again <Y/N>?  ");

            if (Console.ReadLine().ToLower() == "y")
            {
                goto beginning_label;
            }

            Console.Write($"\n\n{name}, thank you for playing!");
            Console.ReadKey();
        }
    }
}
