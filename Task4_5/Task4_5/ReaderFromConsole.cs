using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    class ReaderFromConsole
    {
        public long ReadValue(string name)
        {
            bool isNumber;
            long value;
            do
            {
                Console.WriteLine($"Enter {name}:");
                isNumber = long.TryParse(Console.ReadLine(), out value);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number!");
                }
                else if (value <= 0)
                {
                    isNumber = false;
                    Console.WriteLine("You must enter a positive number!");
                }
            } while (!isNumber);
            return value;
        }
    }
}
