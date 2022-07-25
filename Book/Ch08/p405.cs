using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p405
    {
        struct Point
        {
            public int x;
            public int y;
        }

        static void Main3(string[] args)
        {
            Point point;
            point.x = 10;
            point.y = 10;

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
