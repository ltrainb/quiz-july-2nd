using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    class Book
    {
        public string name { get; set; }
        public double price { get; set; }

        public Book(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
