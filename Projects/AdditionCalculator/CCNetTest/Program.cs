using System;

namespace CCNetTest
{
    class Program
    {
        #region Static Methods

        #region Public Static Methods

        public static decimal AddTwoNumbers(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Adding two numbers...");
			return (firstNumber + secondNumber);
        }

        public static void GetNumbers()
        {
            Console.Write("Please enter your first number: ");
            decimal firstNumber = Decimal.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            var secondNumber = Decimal.Parse(Console.ReadLine());
            var sum = AddTwoNumbers(firstNumber, secondNumber);
            Console.WriteLine("The sum of your two numbers is: " + sum);

            // As if the user wants to run the calculator again
            Console.Write("Do you want to add again(y/n)? ");
            var repeat = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            if (repeat == "y") {
                GetNumbers();
            } else {
                Console.Write("GoodBye");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Addition Calculator");
            Console.WriteLine("-----------------------------------");
            GetNumbers();
            Console.ReadKey();
        }

        #endregion Public Static Methods

        #endregion Static Methods
    }
}