using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some calculations!");
            Console.WriteLine(" ");

            Console.WriteLine("What kind of mathematical operation would you like to perform?");
            Console.WriteLine("Your options are addition, subtraction, multiplication, and division.");
            Console.WriteLine("Enter + to do addition, - to do subtraction, * to do multiplication, or / to do division.");
            string selectedOperation = Console.ReadLine();

            bool doMath = true;
            while (doMath == true)
            {
                switch (selectedOperation)
                {
                    case "+":
                        Console.WriteLine("You've chosen addition.");
                        Console.Write("Please enter your first addend. ");
                        double addendOne = double.Parse(Console.ReadLine());
                        Console.Write("Please enter your second addend. ");
                        double addendTwo = double.Parse(Console.ReadLine());
                        Add(addendOne, addendTwo);
                        break;

                    case "-":
                        Console.WriteLine("You've chosen subtraction.");
                        Console.Write("Please enter a minuend. ");
                        double minuend = double.Parse(Console.ReadLine());
                        Console.Write("Please enter a subtrahend. ");
                        double subtrahend = double.Parse(Console.ReadLine());
                        Subtract(minuend, subtrahend);
                        break;

                    case "*":
                        Console.WriteLine("You've chosen multiplication.");
                        Console.Write("Please enter a multiplicand. ");
                        double multiplicand = double.Parse(Console.ReadLine());
                        Console.Write("Please enter a multiplier. ");
                        double multiplier = double.Parse(Console.ReadLine());
                        Multiply(multiplicand, multiplier);
                        break;

                    case "/":
                        Console.WriteLine("You've chosen division.");
                        Console.Write("Please enter a dividend. ");
                        double dividend = double.Parse(Console.ReadLine());
                        Console.Write("Please enter a diminuend. ");
                        double diminuend = double.Parse(Console.ReadLine());
                        Divide(dividend, diminuend);
                        break;

                    default:
                        Console.WriteLine("Please enter just the operator of the operation you'd like to perform: +, -, *, or /");
                        Console.WriteLine(" ");
                        // selectedOperation = Console.ReadLine(); 
                        break;
                }

                Console.WriteLine("To restart and do another math operation, type the operator of the operation you'd like to do. Or hit Enter to exit the program. ");
                selectedOperation = Console.ReadLine();
                if (selectedOperation != "+" &&
                    selectedOperation != "-" &&
                    selectedOperation != "*" &&
                    selectedOperation != "/")
                {
                    doMath = false;
                }
            }
        }

        private static void Add(double addend1, double addend2) 
        {
            double sum = addend1 + addend2;
            Console.WriteLine($"The sum of your two numbers is {sum}.");
        }

        private static void Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            Console.WriteLine($"The difference of your two numbers is {difference}.");
        }

        private static void Multiply(double multiplicand, double multiplier)
        {
            double product = multiplicand * multiplier;
            Console.WriteLine($"The product of your two numbers is {product}.");
        }

        private static void Divide(double dividend, double diminuend)
        {
            double quotient = dividend / diminuend;
            Console.WriteLine($"The quotient of your two numbers is {quotient}.");
        }
    }
}

