using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * 모델클래스와 list 클래스
 */ 


namespace Book.Ch05
{
    class program
    {
        class student
        {
            public string name;
            public int grade;
        }

        static void Main2(string[] args)
        {
            List<student> list = new List<student>();
            list.Add(new student() { name = "윤인성", grade = 1 });
            list.Add(new student() { name = "연하진", grade = 2 });
            list.Add(new student() { name = "윤아린", grade = 3 });
            list.Add(new student() { name = "윤명월", grade = 4 });
            list.Add(new student() { name = "구지연", grade = 1 });
            list.Add(new student() { name = "김연화", grade = 2 });

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }

        }
    }


    internal class p233
    {
    }
}
