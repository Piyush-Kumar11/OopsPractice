using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPractice
{

//Method Overloading
    internal class Sum
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public double add(double x, double y)
        {
            return x + y;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
