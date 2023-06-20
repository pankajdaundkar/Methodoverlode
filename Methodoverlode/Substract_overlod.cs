using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverlode
{
    public class Substract_overlod
    {
        public int Substract(int x, int y)
        {
            return x - y;
        }
        public int Substract(int a, int b, int c)
        {
            return a - b - c;
        }
        public int Multipy(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public int Addition(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Addition(int n1, int n2, int n3)
        {
            return n1 + n2;
        }
    }
}