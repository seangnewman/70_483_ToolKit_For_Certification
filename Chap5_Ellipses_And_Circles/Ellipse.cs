using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Ellipses_And_Circles
{
    class Ellipse
    {
        public RectangleF Location { get; set; }

        // constructor that takes a RectangleF as a parameter
        public Ellipse(RectangleF rect)
        {
            // Validte width and height
            if(rect.Width <= 0)
            {
              throw new ArgumentOutOfRangeException(
               "width", "Ellipse width must be greater than 0."
              );
            }

            if (rect.Height <= 0)
            {
                throw new ArgumentOutOfRangeException(
                 "height", "Ellipse height must be greater than 0."
                );
            }

            // Save the location
            Location = rect;

        }

        // Constructor that takes x, y, width and height as parameters
        public Ellipse(float x, float y, float width, float height):this(new RectangleF(x, y, width, height))
        {
             
        }
    }
}
