﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/12
 * 이름 : 조경은
 * 내용 : C# 기본 입출력 실습하기 교재 p104
 */
namespace ch02
{
    internal class _4_기본_입출력
    {
        static void Main(string[] args)
        {
            // 이름 입력
            Console.Write("이름입력 :");
            string name = Console.ReadLine();

            // 나이 입력
            Console.Write("나이 입력 : ");
            string age = Console.ReadLine();

            // 주소 입력
            Console.Write("주소입력 : ");
            string addr = Console.ReadLine();   

            Console.WriteLine("===================");
            Console.WriteLine("이름 : " +name);
            Console.WriteLine("나이 : " +age);
            Console.WriteLine("주소 : " +addr);


        }
    }
}
