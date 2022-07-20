using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 8. 하이딩과 오버라이딩
 * 1) new 메서드
 * 1. new 메서드를 사용한 하이딩
 * 
 */

namespace Book.Ch07
{
    internal class p361
    {
        class Program
        {
            class Parent
            {
                public int variable = 273;
                public void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public new string variable = "hiding";
                public new void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main2(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }
    }
}
