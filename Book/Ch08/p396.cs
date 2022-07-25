using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    class Wanted <T>
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }
    internal class p396
    {
        static void Main3(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<Double> wantedDouble = new Wanted<Double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);
        }  
    }
}
