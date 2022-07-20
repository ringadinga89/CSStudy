using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 6. 상속의 생성자
 * - base 키워드를 사용한 생성자 지정(1)
 */


namespace Book.Ch07
{
    internal class p352
    {
        class Program
        {
            class Parent
            {
                public Parent() { Console.WriteLine("부모 생성자"); }
            }

            class Child : Parent
            {
                public Child() : base()
                {
                    Console.WriteLine("자식 생성자");
                }

            }

            static void Main6(string[] args)
            {
                Child childs = new Child();
            }
        }
    }
}
