﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p183
    {
        static void Main183(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });
            
            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
