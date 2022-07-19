using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 오버플로우 
 */ 
namespace Book.Ch02
{
    internal class p82
    {
        static void Main6(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);
        }
    }
}
