using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 7. 섀도잉과 하이딩
 * - 메서드 하이딩
 */

namespace Book.Ch07
{
    internal class p359
    {
        class Program
        {
            class Parent
            {
                public void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public new void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main8(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }

    }
}
