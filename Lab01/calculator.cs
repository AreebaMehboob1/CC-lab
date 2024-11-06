using System;

namespace ScientificCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scientific Calculator");
            Console.WriteLine("Available operations: +, -, *, /, sin, cos, tan, log, clear, exit");
            double accumulator = 0;
            string input;

            while (true)
            {
                Console.WriteLine("Enter an operation (or a number): ");
                input = Console.ReadLine().ToLower();

                // If the input is a number, update the accumulator
                if (double.TryParse(input, out double number))
                {
                    accumulator = number;
                    Console.WriteLine($"Current value: {accumulator}");
                    continue;
                }

                // Perform operations based on input
                switch (input)
                {
                    case "+":
                        Console.WriteLine("Enter another number: ");
                        double addValue = double.Parse(Console.ReadLine());
                        accumulator += addValue;
                        Console.WriteLine($"Result: {accumulator}");
                        break;

                    case "-":
                        Console.WriteLine("Enter another number: ");
                        double subtractValue = double.Parse(Console.ReadLine());
                        accumulator -= subtractValue;
                        Console.WriteLine($"Result: {accumulator}");
                        break;

                    case "*":
                        Console.WriteLine("Enter another number: ");
                        double multiplyValue = double.Parse(Console.ReadLine());
                        accumulator *= multiplyValue;
                        Console.WriteLine($"Result: {accumulator}");
                        break;

                    case "/":
                        Console.WriteLine("Enter another number: ");
                        double divideValue = double.Parse(Console.ReadLine());
                        if (divideValue != 0)
                        {
                            accumulator /= divideValue;
                            Console.WriteLine($"Result: {accumulator}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        break;

                    case "sin":
                        accumulator = Math.Sin(accumulator * Math.PI / 180); // Convert to radians
                        Console.WriteLine($"Sin Result: {accumulator}");
                        break;

                    case "cos":
                        accumulator = Math.Cos(accumulator * Math.PI / 180); // Convert to radians
                        Console.WriteLine($"Cos Result: {accumulator}");
                        break;

                    case "tan":
                        accumulator = Math.Tan(accumulator * Math.PI / 180); // Convert to radians
                        Console.WriteLine($"Tan Result: {accumulator}");
                        break;

                    case "log":
                        if (accumulator > 0)
                        {
                            accumulator = Math.Log10(accumulator); // Log base 10
                            Console.WriteLine($"Log Result: {accumulator}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Logarithm is undefined for non-positive numbers.");
                        }
                        break;

                    case "clear":
                        accumulator = 0;
                        Console.WriteLine("Calculator cleared.");
                        break;

                    case "exit":
                        Console.WriteLine("Exiting calculator.");
                        return;

                    default:
                        Console.WriteLine("Unknown operation.");
                        break;
                }
            }
        }
    }
}
