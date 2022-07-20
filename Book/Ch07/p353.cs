using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 6. 상속의 생성자
 * - base 키워드를 사용한 사용자 지정(2) 
 * 
 */

namespace Book.Ch07
{
    internal class p353
    {
        class Parent
        {
            public Parent() { Console.WriteLine("parent()"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }

        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }

            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }

        static void Main2(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");
        }
    }
}
