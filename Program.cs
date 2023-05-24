using System;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Multiply input by 50
            Console.Write("Enter a number: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            int result1 = number1 * 50;
            Console.WriteLine("Result 1: " + result1);

            // Task 2: Add 25 to input
            Console.Write("Enter another number: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            int result2 = number2 + 25;
            Console.WriteLine("Result 2: " + result2);

            // Task 3: Divide input by 12.5
            Console.Write("Enter a third number: ");
            string input3 = Console.ReadLine();
            double number3 = Convert.ToDouble(input3);
            double result3 = number3 / 12.5;
            Console.WriteLine("Result 3: " + result3);

            // Task 4: Check if input is greater than 50
            Console.Write("Enter a number to compare with 50: ");
            string input4 = Console.ReadLine();
            int number4 = Convert.ToInt32(input4);
            bool result4 = number4 > 50;
            Console.WriteLine("Result 4: " + result4);

            // Task 5: Divide input by 7 and print the remainder
            Console.Write("Enter a number to calculate remainder when divided by 7: ");
            string input5 = Console.ReadLine();
            int number5 = Convert.ToInt32(input5);
            int remainder = number5 % 7;
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
