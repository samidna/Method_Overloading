using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static  class Method_Overload
    {
        public static int MaxNum(int a,int b,int c)
        {
            int max;
            if(a>b) max = a;
            else if(b>c) max = b;
            else max=c;
            return max;
        }
        public static int MaxNum(int a,int b,int c,int d)
        {
            int max = MaxNum(a, b, c);
            if (d>max) return d;
            else return max;
        }

        public static int MaxNum(int a, int b, int c, int d,int e)
        {
            int max = MaxNum(a, b, c,d);
            if (e>max) return e;
            else return max;
        }
    }
}
