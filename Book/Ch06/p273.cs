using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p273
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }

        static void Main5(string[] args)
        {
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
        }
    }
}
