using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _06_08
    {
        static void Main3(string[] args)
        {
            ///////////////////////////////////////////
            ////// LinkedList 실습
            ///////////////////////////////////////////
            LinkedList<string> IKList = new LinkedList<string>();

            IKList.AddLast("김유신");
            IKList.AddLast("김춘추");
            IKList.AddLast("장보고");
            IKList.AddLast("강감찬");
            IKList.AddLast("이순신");
            IKList.AddLast("정약용");

            Console.WriteLine(string.Join(",", IKList));

            LinkedListNode<string> findNode = IKList.Find("이순신");
            LinkedListNode<string> addNode1 = new LinkedListNode<string>("이성계");
            LinkedListNode<string> addNode2 = new LinkedListNode<string>("임꺽정");

            IKList.AddBefore(findNode, addNode1);
            IKList.AddAfter(findNode, addNode2);

            Console.WriteLine(string.Join(",", IKList));
            Console.WriteLine();



            ///////////////////////////////////////////
            ////// SortedList 실습
            ///////////////////////////////////////////
            SortedList<int, string> stList = new SortedList<int, string>();

            stList.Add(101, "한국");
            stList.Add(104, "중국");
            stList.Add(106, "대만");
            stList.Add(103, "일본");
            stList.Add(105, "호주");
            stList.Add(102, "미국");

            Console.WriteLine(string.Join(",", stList));

            for(int i=0; i<stList.Count; i++)  
                Console.WriteLine("stList k:{0}, v:{1}", stList.Keys[i], stList.Values[i]);



        }
    }
}
