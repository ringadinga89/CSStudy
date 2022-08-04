using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 스트림 연습문제 
 * 
 * 객체의 직렬화
 * - 객체를 스트림을 통해 외부 파일로 생성하기 위한 작업.
 * - 스트림으로 전송될 객체는 Serializable 어트리뷰트를 선언한다.
 * - 외부의 객체파일을 다시 객체로 복원하는 것을 역직렬화라고 한다.
 */


namespace Exam._05
{
    [Serializable]
    class Orange
    {
        private string country;
        private int price;

        public Orange(string country, int price)
        {
            this.country = country;
            this.price = price;
        }  
    }

    internal class _05_06
    {

    }
}
