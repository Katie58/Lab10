using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Circ();
            Exit();
        }

        public static void Circ()
        {
            int count = 0;
            bool retry = true;
            while (retry)
            {
                bool valid = false;
                while (!valid)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Circle Tester");
                    Console.Write("Please enter a radius:  ");
                    if (double.TryParse(Console.ReadLine(), out double radius))
                    {
                        valid = true;
                        Circle circ = new Circle(radius);
                        circ.Radius = radius;
                        Console.WriteLine(circ.CalculateFormattedCircumference());
                        Console.WriteLine(circ.CalculateFormattedArea());
                        count += 1;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Entry, Please Try Again...");
                    }
                }
                retry = Retry();
            }
            Console.WriteLine($"Goodbye, you created {count} circles! Press ESCAPE to exit...");
        }

        public static bool Retry()
        {
            Console.WriteLine("\nTry Again? (y/n)  ");
            bool retry = true;
            bool valid = false;
            while (!valid)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    valid = true;
                    retry = true;
                }
                else if (key == ConsoleKey.N)
                {
                    valid = true;
                    retry = false;
                }
                else
                {
                    valid = false;
                    retry = false;
                }
            }
            return retry;
        }

        public static void Exit()
        {            
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Exit();
            }
        }
    }
}
