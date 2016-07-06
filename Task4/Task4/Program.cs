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
