using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double F;
            Console.WriteLine("Введите a"); 
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");  
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c"); 
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите d"); 
            d = Convert.ToDouble(Console.ReadLine());
            F = (a * b + c * d) + (a * d - b * c);
            Console.Write("Результат: " + F);
            Console.ReadKey();

        }
    }
}
