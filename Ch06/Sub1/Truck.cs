using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Truck : Car
    {

        private int capacity;

        public Truck(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.capacity = cc; 
        }

        public override void SpeedDown(int speed)
        {

        }

        public override void SpeedUp(int speed)
        {

        }
    }
}
