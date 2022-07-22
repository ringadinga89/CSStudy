using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/21
 * 이름 : 조경은
 * 내용 : 인덱서 실습하기 교재 p398
 *  
 * 인덱서 (Indexer)
 * - 객체를 배열처럼 인덱스를 활용해서 객체의 속성을 참조할 수 있게 해주는 속성
 * - 인덱서를 메서드로 대체 가능
 */

namespace Ch06
{
    class MyArray
    {
        private int[] array;

        public MyArray()
        {
            array = new int[3]; // array 생성자에서 배열의 크기가 정해진것 
        }

        // 인덱서
        public int this[int i]
        {
            get { return array[i]; } // 이 자리 i자리에 0이 넣어짐
            set
            {
                if (i < array.Length)
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("더 이상 데이터를 저장할 수 없습니다.");
                }
            
            }
        }


    }

    internal class _5_인덱서
    {
        static void Main4(string[] args)
        {
            MyArray mArr = new MyArray();
            mArr[0] = 100; // mArr을 인덱서로 호출하기. 객체 그 자체로 호출
            mArr[1] = 200;
            mArr[2] = 300; // 배열이 3칸이라서 안에 3넣는건 안됨. 0,1,2만 넣을 수 있음
            mArr[3] = 400;

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(mArr[i] + " ");
            }
        }

    }
}
