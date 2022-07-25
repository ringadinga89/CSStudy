﻿using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/25
 * 이름 : 조경은
 * 내용 : 컬렉션 리스트 실습하기 교재 p211 (리스트)
 * 
 * 리스트 (List)
 * - 배열과 유사한 선형자료구조로 배열과 다르게 동적으로 데이터를 처리
 * - ArrayList 일반화 시켜 더 나은 성능을 가진 List를 사용 
 */

namespace Ch07
{
    internal class _3_List
    {
        static void Main4(string[] args)
        {
            //////////////////////////////////////////////
            /// ArrayList
            //////////////////////////////////////////////
           
            /// ArrayList 생성
            ArrayList arrlist1 = new ArrayList();

            // 데이터 추가
            arrlist1.Add(1);
            arrlist1.Add(2);
            arrlist1.Add(3);
            arrlist1.Add(4);
            arrlist1.Add(5);

            // 데이터 삽입
            arrlist1.Insert(1, 6);

            // 데이터 삭제 
            arrlist1.Remove(6);
            arrlist1.RemoveAt(0);

            // 데이터 출력
            foreach (int n in arrlist1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            
            // 다양한 타입의 데이터를 찾는 ArrayList
            ArrayList arrlist2 = new ArrayList();
            arrlist2.Add(1);
            arrlist2.Add(1.23);
            arrlist2.Add(true);
            arrlist2.Add('A');
            arrlist2.Add("Apple");

            for(int i = 0; i < arrlist2.Count; i++)
            {
                Console.Write(arrlist2[i] + " ");
            }
            Console.WriteLine();





            //////////////////////////////////////////////
            /// List
            //////////////////////////////////////////////

            /// List 생성
            List<int> list1 = new List<int>();

            // 데이터 추가
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            // 데이터 삽입
            list1.Insert(1, 6);

            // 데이터 삭제
            list1.Remove(4);
            list1.RemoveAt(1);


            // 데이터 출력
            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // 문자열 리스트
            List<string> list2 = new List<string>();
            list2.Add("서울");
            list2.Add("대전");
            list2.Add("대구");
            list2.Add("부산");
            list2.Add("광주");

            foreach (string city in list2)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();


            // 객체 리스트 
            List<Apple> list3 = new List<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 2000));
            list3.Add(new Apple("일본", 1000));

            Apple apple = list3[0];
            apple.Show();

            list3[1].Show();
            list3[2].Show();
        }
    }
}
