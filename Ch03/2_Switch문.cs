using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 날짜 : 2022-07-13
 * 이름 : 조경은
 * 내용 : 조건문 Switch 실습하기 교재 p.127
 */
namespace Ch03
{
    internal class _2_Switch문
    {
        static void Main4(string[] args)
        {
            Console.Write("숫자 임력 : ");
            string strNum = Console.ReadLine();

            int number = int.Parse(strNum);
        
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine($"{number}는 짝수 입니다.");
                    break;
                case 1:
                    Console.WriteLine($"{number}는 홀수 입니다.");
                    break;
            }
        }
    }
}
