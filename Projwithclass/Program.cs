using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projwithclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator comparator = new Comparator();
             

            Console.WriteLine("Введи первое число");
            string third = Console.ReadLine();
            Console.WriteLine("Введи второе число");
            string four = Console.ReadLine();
           
            int a = Convert.ToInt32(third);
            int b = Convert.ToInt32(four);
            int result = comparator.findMax(a, b);

            Console.WriteLine("\n" + result + " является наибольшим числом");
            Console.ReadKey();



        }
    }
}
