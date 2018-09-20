using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Ellipses_And_Circles
{
    class Circle : Ellipse
    {

        // constructor that takes a RectangleF as a parameter
        public Circle(RectangleF rect) : base(rect)
        {
            // Validate width and height
            if(rect.Width != rect.Height)
            {
                throw new ArgumentOutOfRangeException(
                  "width and height", "Circle width and height must be the same"    
                    );
            }
        }

        //Constructor that takes x, y, width and height as parameters
        public Circle(float x, float y, float width, float height):this(new RectangleF(x, y, width, height))
        {

        }
    }
}
