using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_image_processing
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Radius { get; set; }

        public Circle(int x, int y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
}
