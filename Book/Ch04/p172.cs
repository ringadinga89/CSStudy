﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p172
    {
        static void Main172(string[] args)
        {
            // 변수를 선언합니다.
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            // 반복을 수행합니다.
            foreach (string item in array)
            {
                // 출력합니다.
                Console.WriteLine(item);
            }
        }
    }
}
