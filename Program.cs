using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Laboratory_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numapples, total;
            int cprice;

            // ask the usee how many apples they buy
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Enter the number of apples you want to purchase:");
            numapples = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            // calculated price of apple by deviding it to 3
            double pricePerApple = 32.50;

            // Calculate the total price of apples
            total = numapples * pricePerApple;

            //the price 
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The total price of " + numapples + " apples is " + total );
            Console.WriteLine("--------------------------------------------------");

            // convert total price to int 
            cprice = (int)total;

            //converted price
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The value of the converted price is " + cprice );
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
