﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p267
    {
        class Test
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }

        static void Main1(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multi(52, 273));
            Console.WriteLine(test.Multi(108, 32));
        }
    }
}
