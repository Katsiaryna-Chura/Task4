using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Menu
    {
        public bool PerformMenuItem(int menuItem, Cart cart)
        {
            ProductList listOfProducts = ProductList.Instance;
            switch (menuItem)
            {
                case 1:
                    Console.WriteLine(cart.ToString());
                    break;
                case 2:
                    Console.WriteLine(listOfProducts.ToString());
                    if (listOfProducts.isEmpty())
                    {
                        return true;
                    }
                    Product selectedProduct = listOfProducts.GetProduct(SelectProduct());
                    if (selectedProduct == null)
                    {
                        Console.WriteLine("There is no product with such number.");
                        return true;
                    }
                    int numberOfUnits = GetNumberOfUnits();
                    if (!cart.AddItem(selectedProduct, numberOfUnits))
                    {
                        Console.WriteLine("Selected product already exists in the cart.");
                    }
                    break;
                case 3:
                    Console.WriteLine(cart.ToString());
                    if (cart.isEmpty())
                    {
                        return true;
                    }
                    int productNumber = SelectProduct();
                    if (!cart.DeleteItem(productNumber))
                    {
                        Console.WriteLine("There is no such product in the cart.");
                    }
                    break;
                case 4:
                    Console.WriteLine($"Total cost = {cart.GetTotalCost()}");
                    break;
                case 5:
                    return false;
                default:
                    Console.WriteLine("There is no such menu item.");
                    break;
            }
            return true;
        }

        public void ViewMenu()
        {
            Console.WriteLine("Select the menu item:");
            Console.WriteLine("1 - View contents of the cart");
            Console.WriteLine("2 - Add item to the cart");
            Console.WriteLine("3 - Remove item from the cart");
            Console.WriteLine("4 - Calculate the total cost");
            Console.WriteLine("5 - exit");
        }

        public int SelectMenuItem()
        {
            int menuItem;
            bool isNumber;
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out menuItem);
                if (!isNumber)
                {
                    Console.WriteLine("Enter a number please!");
                }
            } while (!isNumber);
            return menuItem;
        }

        public int SelectProduct()
        {

            int productId;
            bool isNumber;
            do
            {
                Console.WriteLine("Enter the product number:");
                isNumber = int.TryParse(Console.ReadLine(), out productId);
                if (!isNumber)
                {
                    Console.WriteLine("Enter a number please!");
                }
            } while (!isNumber);
            return productId;
        }

        public int GetNumberOfUnits()
        {
            int numberOfUnits;
            bool isNumber;
            do
            {
                Console.WriteLine("Enter the number of units of product:");
                isNumber = int.TryParse(Console.ReadLine(), out numberOfUnits);
                if (!isNumber)
                {
                    Console.WriteLine("Enter a number please!");
                }
                if (numberOfUnits <= 0)
                {
                    isNumber = false;
                    Console.WriteLine("Number of units must be > 0.");
                }
            } while (!isNumber);
            return numberOfUnits;
        }

    }
}
