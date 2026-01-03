using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Rectangle
    {
        private int a, b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Area()
        {
            return a * b;
        }
        public int Perimeter()
        {
            return 2 * (a + b);
        }
    }
}
