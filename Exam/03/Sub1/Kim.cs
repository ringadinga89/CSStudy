using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    internal class Kim
    {
        private string name;
        private int age;

        public Kim(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("------------------");
        }
    }
}
