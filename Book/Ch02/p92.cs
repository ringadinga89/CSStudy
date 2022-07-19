using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/* 문자열과 관련된 복합 대입 연산자
 * 문자열 자료형 변수 output을 만들고 복합 대입연산자를 사용해보자.
 */


namespace Book.Ch02
{
    internal class p92
    {
        static void Main22(string[] args)
        {
            static void Main(string[] args)
            {
                string output = "hello ";
                output += "world ";
                output += "!";

                Console.WriteLine(output);
                
            }
        }
    }
}
