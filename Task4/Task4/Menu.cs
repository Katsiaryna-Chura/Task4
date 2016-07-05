using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task4
{
    class Menu
    {
        public int SelectMenuItem()
        {
            int choice;
            bool isNumber;
            do
            {
                ViewMenu();
                Console.WriteLine("Select menu item:");
                isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (!isNumber)
                {
                    Console.WriteLine("Enter a number please!");
                }
            } while (!isNumber);
            return choice;
        }

        public void ViewMenu()
        {
            Console.WriteLine("1 - Calculate factorial(n)");
            Console.WriteLine("2 - Calculate fibonacci(n)");
            Console.WriteLine("3 - Exit");
        }

        public int ReadValueFromConsole()
        {
            bool isNumber;
            int n;
            do
            {
                Console.WriteLine("Enter n:");
                isNumber = int.TryParse(Console.ReadLine(), out n);
                if (!isNumber)
                {
                    Console.WriteLine("Enter a number please!");
                }
            } while (!isNumber);
            return n;
        }

        public bool PerformMenuItem(int choice)
        {
            Mathematics math = new Mathematics();
            int n;
            switch (choice)
            {
                case 1:
                    n = ReadValueFromConsole();
                    BigInteger? result = math.Factorial(n);
                    if (result == null)
                    {
                        Console.WriteLine($"{n} < 0. It's impossible to calculate factorial of negative number.");
                    }
                    else
                    {
                        Console.WriteLine($"Factorial({n}) = {result}");
                    }
                    break;
                case 2:
                    n = ReadValueFromConsole();
                    Console.WriteLine($"Fibonacci({n}) = {math.Fibonacci(n)}");
                    break;
                case 3:
                    return false;
                default:
                    Console.WriteLine("There is no such menu item.");
                    break;
            }
            return true;
        }
    }
}
