using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * is 키워드
 */

namespace Book.Ch07
{
    internal class p346
    {
        static void Main3(string[] args)
        {
            List<Animal> Animals = new List<Animal>() { };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { }
                if (item is Cat) { }
            }
        }
    }
}
