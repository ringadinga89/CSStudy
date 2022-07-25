using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* IDisposable 인터페이스
 */


namespace Book.Ch09
{
    internal class p430
    {
        class Program
        {
            class Dummy : IDisposable
            {
                public void Dispose()
                {
                    Console.WriteLine("Dispose() 메서드를 호출합니다.");
                }
            }

            static void Main2(string[] args)
            {
                using (Dummy dummy = new Dummy()) ;

                // 이렇게 하거나 
                //// Dummy dummy = new Dummy();
                //// dummy.Dispose();
                //// 이렇게 해도됨
            }
        }
    }
}
