using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    class Program
    {
       public static void Main(string[] args)
        {
            int value;
            Book comicBook = new Book("Marvel vs DC", 21.99);
            Book noval = new Book("Deception Point", 25.00);
            value=compareBooks(comicBook, noval);
            Console.WriteLine(value);
            Console.ReadKey();


        }
        public static int compareBooks( Book book1,  Book  book2)
        {
            int value;
            if (book1.price == book2.price)
                value= 0;
            else if (book1.price > book2.price)
                value= 1;
            else
                value=-1;
            return value;

        }
    }
}
