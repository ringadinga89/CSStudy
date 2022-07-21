using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 날짜 : 2022/07/21
 * 이름 : 조경은
 * 내용 : 클래스 연습문제
 */

namespace Exam._03
{
    internal class _03_01
    {
        private string name;
        private int age;

        public _03_01(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("이름 : " + this.name);
            Console.WriteLine("나이 : " + this.age);
            Console.WriteLine("------------------");
        }

        static void Main4(string[] args)
        {
            Kim kim = new Kim("김유신", 23);
            Lee lee = new Lee("이순신", 31);

            kim.Show();
            lee.Show();
            
        }
    }
}
