using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/26
 * 이름 : 조경은
 * 내용 : 예외 던지기 실습하기 교재 
 * 
 */

namespace Ch08
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height) // 생성자
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                // 예외던지기(예외 강제 발생)          (exception객체)
                throw new Exception("크기는 0보다 작을 수 없습니다.");
            }
        }

        public void Area()
        {
            Console.WriteLine("Box 넓이 : " + width * height);
        }
    }


    internal class _2_예외던지기
    {
        static void Main4(string[] args)
        {
            try
            {
                Box box1 = new Box(10, 10); // 여기 박스로 throw ~~ 가 던져짐
                box1.Area();

                Box box2 = new Box(-10, -10); // 여기 박스로 throw ~~ 가 던져짐 box는 에러문장뜸
                box2.Area();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                           
        }
    }
}
