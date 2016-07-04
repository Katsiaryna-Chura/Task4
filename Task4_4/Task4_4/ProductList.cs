using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class ProductList
    {
        private static ProductList instance;
        public static List<Product> listOfProducts { get; private set; }

        private ProductList()
        {
            listOfProducts = new List<Product>();
            listOfProducts.Add(new Product(1, "Table", 10));
            listOfProducts.Add(new Product(2, "Sofa", 30));
            listOfProducts.Add(new Product(3, "Chair", 5));
            listOfProducts.Add(new Product(4, "Armchair", 15));
            listOfProducts.Add(new Product(5, "Cupboard", 12));
            listOfProducts.Add(new Product(6, "Bookshelf", 8));
        }

        public static ProductList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductList();
                }
                return instance;
            }
        }

        public bool isEmpty()
        {
            return listOfProducts.Count == 0;
        }

        public Product GetProduct(int id)
        {
            Product neededProduct = null;
            foreach (var product in listOfProducts)
            {
                if (product.ID == id)
                {
                    neededProduct = product;
                }
            }
            return neededProduct;
        }

        public override string ToString()
        {
            if (listOfProducts.Count == 0)
            {
                return "The list of products is empty.";
            }
            string productsInfo = "List of products:\n";
            foreach (var product in listOfProducts)
            {
                productsInfo += product.ToString() + "\n";
            }
            return productsInfo;
        }
    }
}
