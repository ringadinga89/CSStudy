using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 6. 상속의 생성자
 * - 상속했을 때 기본적인 생성자 호출 순서
 */


namespace Book.Ch07
{
    internal class p351
    {
        class program
        {
            class Parent
            {
                public Parent()
                {
                    Console.WriteLine("부모 생성자");
                }
            }

            class Child : Parent
            {
                public Child()
                {
                    Console.WriteLine("자식 생성자");
                }
            }

            static void Main1(string[] args)
            {
                Child child = new Child();
            }
        }
    }
}


    
