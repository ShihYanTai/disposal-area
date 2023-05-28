using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleLibrary
{
    public class circle
    {
        public double _radius = 0;
        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }
        public double getSize() => 3.14159 * Math.Pow(_radius, 2);
    }
}
