using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }

        public Product() { }

        public Product(int id, string name, long price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{ID} - name: {this.Name,10}, price: {this.Price,7};";
        }
    }
}
