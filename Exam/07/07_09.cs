﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * enum(enumerate) 자료형
 * - 열거형은 서로 관련있는 상수들의 집합을 정의해 놓은 자료형
 * - 숫자에 특정한 명칭을 지정해서 의미를 쉽게 이해할 용도로 사용
 */


namespace Exam._07
{
    internal class _07_09
    {
        enum Size { Short, Tall, Grande, Venti };
        enum Coffee {  Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 };

        static void Main2(string[] args)
        {
            Console.WriteLine("커피 가격표");

            for (int i=0; i<4; i++)
            {
                if(i == (int)Size.Short)
                {
                    Console.WriteLine("{0,10) : {1:C}", Size.Short, Convert.ToInt32(Coffee.Short));
                }
                else if (i == (int)Size.Tall)
                {
                    Console.WriteLine("{0,10}, {1:C}", Size.Tall, Convert.ToInt32(Coffee.Tall));
                }
                else if (i == (int)Size.Grande)
                {
                    Console.WriteLine("{0,10}, {1:C}", Size.Grande, Convert.ToInt32(Coffee.Grande));
                }
                else if( i == (int)Size.Venti)
                {
                    Console.WriteLine("{0,10}, {1:C}", Size.Venti, Convert.ToInt32(Coffee.Venti));
                }
            }
        }
    }
}
