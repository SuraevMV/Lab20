using System;
using System.Collections.Generic;
using System.Text;

namespace Lab20
{
    class Task
    {
        static public double Length(double r) 
        {
            double l = Math.PI * 2 * r;
            Console.WriteLine("{0:f3}", l);
            return l;
        }
        static public double Square(double r)
        {
            double s = Math.PI * r * r;
            Console.WriteLine("{0:f3}",s);
            return s;
        }

        static public double Volume(double r)
        {
            double v = 4 / 3 * Math.PI * 4 * Math.Pow(r, 3);
            Console.WriteLine("{0:f3}", v);
            return v;
        }
        

    }
}
