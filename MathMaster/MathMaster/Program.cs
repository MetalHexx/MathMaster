using System;

namespace MathMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Math Master";
            Console.WriteLine("Welcome to the Math Master.  Press any key to start calculating!");
            Console.WriteLine();
            Console.ReadKey();

            DivideNumber(2, 0, 100);
            DivideNumber(2, 15, 200);
            DivideNumber(3, 1, 100);
            DivideNumber(3, 15, 200);

            AddNumber(2, 1, 100);
            AddNumber(2, 15, 200);
            AddNumber(3, 1, 100);
            AddNumber(3, 15, 200);

            SubtractNumber(2, 1, 100);
            SubtractNumber(2, 15, 200);
            SubtractNumber(3, 1, 100);
            SubtractNumber(3, 15, 200);

            MultiplyNumber(2, 1, 100);
            MultiplyNumber(2, 15, 200);
            MultiplyNumber(3, 1, 100);
            MultiplyNumber(3, 15, 200);

            Console.WriteLine("Finished executing.  Press any key to end the program.");
            Console.ReadKey();
        }

        static void DivideNumber(int numberToDivide, int xStart, int xEnd)
        {
            Console.WriteLine($"************Starting DivideNumber for {numberToDivide} from {xStart} to {xEnd}************");
            for (decimal x = xStart; x <= xEnd; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You cannot possibly divide a number by zero...duuh!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                decimal result = numberToDivide / x;
                Console.WriteLine($"{numberToDivide} / {x} = {result}");
            }
            Console.WriteLine();

        }

        static void AddNumber(int numberToAdd, int xStart, int xEnd)
        {
            Console.WriteLine($"************Starting AddNumber for {numberToAdd} from {xStart} to {xEnd}************");
            for (decimal x = xStart; x <= xEnd; x++)
            {
                decimal result = numberToAdd + x;

                Console.WriteLine($"{numberToAdd} + {x} = {result}");
            }
            Console.WriteLine();

        }

        static void SubtractNumber(int numberToSubtract, int xStart, int xEnd)
        {
            Console.WriteLine($"************Starting SubtractNumber for {numberToSubtract} from {xStart} to {xEnd}************");
            for (decimal x = xStart; x <= xEnd; x++)
            {
                decimal result = numberToSubtract - x;

                Console.WriteLine($"{numberToSubtract} - {x} = {result}");
            }
            Console.WriteLine();

        }

        static void MultiplyNumber(int numberToMultiply, int xStart, int xEnd)
        {
            Console.WriteLine($"************Starting MultiplyNumber for {numberToMultiply} from {xStart} to {xEnd}************");
            for (decimal x = xStart; x <= xEnd; x++)
            {
                decimal result = numberToMultiply * x;

                Console.WriteLine($"{numberToMultiply} * {x} = {result}");
            }
            Console.WriteLine();

        }
    }
}
