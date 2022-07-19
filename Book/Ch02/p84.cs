using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 실수 변수 생성
 * float : 4바이트의 실수
 * double : 8바이트의 실수
 */


namespace Book.Ch02
{
    internal class p84
    {
        static void Main2(string[] args)
        {
            double a = 52.273;
            double b = 103.32;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}
