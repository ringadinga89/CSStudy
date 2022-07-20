using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 8. 하이딩과 오버라이딩
 * 2) virtual과 override 메서드
 * 2. virtual과 override 메서드를 사용한 오버라이딩
 * 
 */

namespace Book.Ch07
{
    internal class p362
    {
        class Program
        {
            class Parent
            {
                public virtual void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public override void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main5(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }
    }
}
