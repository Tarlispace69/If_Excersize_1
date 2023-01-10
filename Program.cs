using System;

namespace If_Excersize_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int num1, num2, num3, average;

            //receiving first input
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            //receiving second input
            Console.WriteLine("Enter first number: ");
            num2 = int.Parse(Console.ReadLine());

            //receiving third input
            Console.WriteLine("Enter first number: ");
            num3 = int.Parse(Console.ReadLine());

            //calculating average
            average = (num1 + num2 + num3) / 3;

            //checking if average is between -10 and 10
            if (average>=-10 && average<=10)
            {
                Console.WriteLine($"Inputs were: {num1} {num2} {num3}");
                Console.WriteLine($"Average is: {average}");
            }

        }
    }
}
