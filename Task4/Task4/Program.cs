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
            //Point p = new Point(1,2);
            //Point r = null;
            //Console.WriteLine(p.Equals(r));
            //Console.WriteLine(p.Equals(new Point(1,2)));
            //Console.WriteLine(p.Equals(new Point(2,1)));
            //Console.WriteLine(p.Equals(1));
            //Console.WriteLine(p.Equals("text"));

            //SelfAwareClass s1 = new SelfAwareClass();
            //Console.WriteLine($"Number of copies: {SelfAwareClass.NumberOfCopies}");
            //for (int i = 0; i < 1000; i++)
            //{
            //    SelfAwareClass s = new SelfAwareClass();
            //}
            //Console.WriteLine($"Number of copies: {SelfAwareClass.NumberOfCopies}");
            //s1 = null;
            //for (int i = 0; i < 1000000; i++)
            //{
            //    SelfAwareClass s = new SelfAwareClass();
            //}
            //Console.WriteLine($"Number of copies: {SelfAwareClass.NumberOfCopies}");
            //string choice = null;

            //BigInteger? fact = Mathematics.Factorial(50000);
            //Console.WriteLine($"Factorial(50000) = {Mathematics.Factorial(50000)}");

            int n = 22;
            Console.WriteLine($"Fibonacci({n}) = {Mathematics.Fibonacci(n)}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

    }
}
