﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Sedan : Car
    {

        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public override void SpeedDown(int speed)
        {
            base.Speed -= speed;
            Console.WriteLine("Sedan SpeedDown...");
        }

        internal static void SpeedDpwn(int v)
        {
            
        }

        public override void SpeedUp(int speed)
        {
            base.Speed += speed;
            Console.WriteLine("Sedan SpeedUp...");
        }

        public new void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("속도 : " + speed);
            Console.WriteLine("배기량 : " + cc);
        }
    }
}
