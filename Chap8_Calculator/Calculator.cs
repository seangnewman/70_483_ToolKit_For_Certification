using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Calculator
{
    class Calculator
    {
        private int x;

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        private int y;

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Divide()
        {
            if( this.Y == 0)
            {
                return 0;
            }
            else
            {
                return this.X / this.Y;
            }
        }

        public double Exponent(double power)
        {
            return Math.Pow(this.x, power);
        }


    }
}
