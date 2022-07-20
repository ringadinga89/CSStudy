using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 7. 섀도잉과 하이팅
 * - 하이딩
 */


namespace Book.Ch07
{
    internal class p358
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "shadowing";
        }

        static void Main2(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
        }
    }
}
