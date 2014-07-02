using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_july_2nd
{
    class Program
    {
       public static void Main(string[] args)
        {
            string num1, num2;
            Console.WriteLine("Please enter an integer: ");
            num1=Console.ReadLine();
            Console.WriteLine("Please enter a second integer: ");
            num2=Console.ReadLine();
            smallestInt(Convert.ToInt32(num1), Convert.ToInt32(num2));
            
        }
        public static void smallestInt( int num1, int num2)
        {
            int smallest;
            if (num1 > num2)
                smallest = num2;
            else
                smallest = num1;
            Console.WriteLine(smallest + " Is the smallest Integer");
            Console.ReadKey();
                
        }
    }
}
