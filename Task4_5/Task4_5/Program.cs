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
            ReaderFromConsole reader = new ReaderFromConsole();
            RectanglesCounter counter = new RectanglesCounter();
            W = reader.ReadValue("total width");
            H = reader.ReadValue("total height");
            w = reader.ReadValue("width of the rectangle");
            h = reader.ReadValue("height of the rectangle");
            Console.WriteLine($"Square = {W}*{H}, rectangle = {w}*{h}, Number of rectangles in the square = {counter.GetCountOfRectangles(W,H,w,h)}");
            Console.ReadLine();
        }
    }
}
