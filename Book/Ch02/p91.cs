using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 숫자와 관련된 복합 대입 연산자
 * 
 *         += 숫자 덧셈 후 대입 연산자
 *         -= 숫자 뺄셈 후 대입 연산자
 *         *= 숫자 곱셈 후 대입 연산자
 * ㄱ      /= 숫자 나눗셈 후 대입 연산자
 * 
 * 정수 자료형인 변수 output을 만들고 복합 대입 연산자를 적용해보자.
 */


namespace Book.Ch02
{
    internal class p91
    {
        static void Main1(string[] args)
        {
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
        }
    }
}
