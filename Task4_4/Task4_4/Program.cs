using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Menu menu = new Menu();
            bool isContinue = false;
            do
            {
                menu.ViewMenu();
                int menuItem = menu.SelectMenuItem();
                isContinue = menu.PerformMenuItem(menuItem, cart);
            } while (isContinue);

        }
    }
}
