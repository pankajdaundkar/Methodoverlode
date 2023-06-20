using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverlode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Substract_overlod sub = new Substract_overlod();
            int result = sub.Substract(5, 2);
            Console.WriteLine(result);

            Substract_overlod sub1 = new Substract_overlod();
            int result1 = sub1.Substract(7,8,9);
            Console.WriteLine(result1);
           
            Substract_overlod mul = new Substract_overlod();
            int res = mul.Multipy(3,6);
            Console.WriteLine(res);

            Substract_overlod mul2 = new Substract_overlod();
            int res1 = mul2.Multiply(3,6,5);
            Console.WriteLine(res1);

            Substract_overlod add = new Substract_overlod();
            int res3 = add.Addition(5, 1);
            Console.WriteLine(res3);

            Substract_overlod add1 = new Substract_overlod();
            int res4 = add1.Addition(7,8,9);
            Console.WriteLine(res4);
        }
         
    }
}
