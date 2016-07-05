using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {


            //BigInteger? fact = Mathematics.Factorial(50000);
            //Console.WriteLine($"Factorial(50000) = {Mathematics.Factorial(50000)}");

            //int n = 22;
            //Console.WriteLine($"Fibonacci({n}) = {Mathematics.Fibonacci(n)}");
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadLine();
            Menu menu = new Menu();
            bool isContinue;
            int menuItem;
            do
            {
                menuItem = menu.SelectMenuItem();
                isContinue = menu.PerformMenuItem(menuItem);
            } while (isContinue);
        }

    }
}
