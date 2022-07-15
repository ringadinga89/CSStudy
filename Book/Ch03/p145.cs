using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p145
    {
        static void Main13(string[] args)
        {
            Console.WriteLine("입력: ");
            String Line = Console.ReadLine();

            if (Line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            { 
                Console.WriteLine("^^");
            }
        }
    }
}
