using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler((s, a) =>
            {
                Console.Clear();
                a.Cancel = false;
                Environment.Exit(0);
            });

            var factorial = new Factorial();

            do
            {
                Console.Write("Enter number: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    var fact = factorial.Calculate(value);
                    var result = fact == -1 ? "Overflow error" : $"Factorial of {value}: {fact}";
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            } while (true);
        }
    }
}
