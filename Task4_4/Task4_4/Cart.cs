using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Cart
    {
        public Dictionary<Product, int> items { get; private set; }

        public Cart()
        {
            items = new Dictionary<Product, int>();
        }

        public bool isEmpty()
        {
            return items.Count == 0;
        }

        public bool AddItem(Product product, int number)
        {
            try
            {
                items.Add(product, number);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public bool DeleteItem(int id)
        {
            Product productToDelete = null;
            foreach (var item in items)
            {
                if (item.Key.ID == id)
                {
                    productToDelete = item.Key;
                    break;
                }
            }
            if (productToDelete == null)
            {
                return false;
            }
            return items.Remove(productToDelete);
        }

        public long GetTotalCost()
        {
            long totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Key.Price * item.Value;
            }
            return totalCost;
        }

        public override string ToString()
        {
            if (items.Count == 0)
            {
                return "The cart is empty.";
            }
            string contentsOfCart = "Cart contains:\n";
            foreach (var item in items)
            {
                contentsOfCart += item.Key.ToString() + $" number:{item.Value,5}\n";
            }
            return contentsOfCart;
        }
    }
}
