﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._08
{
    internal class _08_05
    {
        static void Main6(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j = 2; j <= 1; j++)
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine("{0,2}! = {1,10:#,#}", i, fact);
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:n0}\n", n, sum);
        }
    }
}
