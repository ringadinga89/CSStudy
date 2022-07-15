using System;
using System.Threading;

namespace Book.Ch04
{
    internal class p187
    {
        static void Main187(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                // 화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                // 출력합니다.
                if (x % 3 == 0)
                    Console.WriteLine(" __@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");

            }
        }
    }
}
