using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * sizeof 연산자
 * 각각의 자료형이 몇 바이트인지 sizeof 연산자를 통해 확인가능
*/

namespace Book.Ch02
{
    internal class p86
    {
        static void Main65(string[] args)
        {
            Console.WriteLine("int: "+sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

        }
    }
}
