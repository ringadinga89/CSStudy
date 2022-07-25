using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 8. 하이딩과 오버라이딩
 * 3) 활용
 * 3. 하이딩
 * 
 */

namespace Book.Ch07
{
    internal class p364
    {
        class Program
        {
            class Animal
            {
                public virtual void Eat()
                {
                    Console.WriteLine("냠냠 먹습니다.");
                }
            }

            class Dog : Animal
            {
                public new void Eat()
                {
                    Console.WriteLine("강아지 사료를 먹습니다.");
                }
            }

            class Cat : Animal
            {
                public override void Eat()
                {
                    Console.WriteLine("고양이 사료를 먹습니다.");
                }
            }

            static void Main3(string[] args)
   
            {
                List<Animal> Animals = new List<Animal>()
                {
                    new Dog(), new Cat(), new Cat(), new Dog(),
                    new Dog(), new Cat(), new Dog(), new Dog()
                };

                foreach (var item in Animals)
                {
                    item.Eat();
                }
            }
        }
    }
}
