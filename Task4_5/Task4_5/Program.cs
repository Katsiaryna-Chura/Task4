using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long W, H, w, h;
            W = EnterValue("total width");
            H = EnterValue("total height");
            w = EnterValue("width of the rectangle");
            h = EnterValue("height of the rectangle");
            Console.WriteLine($"Square = {W}*{H}, rectangle = {w}*{h}, Number of rectangles in the square = {RectanglesCounter.GetCountOfRectangles(W,H,w,h)}");
            Console.ReadLine();
        }

        public static long EnterValue(string name)
        {
            bool isNumber;
            long value;
            do
            {
                Console.WriteLine($"Enter {name}:");
                isNumber = long.TryParse(Console.ReadLine(),out value);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number!");
                }
                else if(value <= 0)
                {
                    isNumber = false;
                    Console.WriteLine("You must enter a positive number!");
                }
            } while (!isNumber);
            return value;
        }
    }
}
