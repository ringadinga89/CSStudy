using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/21
 * 이름 : 조경은
 * 내용 : 제네릭 실습하기 교재 p404
 * 
 * 제네릭(Generic)
 * - 클래스 내부의 변수외 타입을 동적으로 일반화 시키는 문법 요소
 * - 제네릭 사용으로 클래스를 범용성 있게 사용한다.
 * 
 */

namespace Ch06
{
    class FruitBox<T> // 치환변수 T를 한곳 여기를 제네릭 박스
    {
        private T fruit; // 참조선언-애플 컨트롤+. 해주기

        public FruitBox(T fruit)
        {
            this.fruit = fruit;
        }

        public T Fruit { get => fruit;} // 필드캡슐화 그러나 어쩌고 설정해주기

        public T GetFruit()
        {
            return fruit;
        }
    }




    internal class _4_제네릭
    {
        static void Main6(string[] args)
        {
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 2000);

            FruitBox<Apple> box1 = new FruitBox<Apple>(apple); // 치환할 과일을 <>안에 넣어주기
            FruitBox<Banana> box2 = new FruitBox<Banana>(banana);

            box1.Fruit.Show();
            box2.GetFruit().Show();
        }

    }
}
