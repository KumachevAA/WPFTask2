using System;

namespace WPFTask2._1.Models
{
    public class Circle : Shape
    {
        protected double radius;

        protected double Area()
        {
            return Math.PI * radius * radius;
        }

        protected double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public Circle()
        {

        }

        public Circle(double Radius)
        {
            radius = Radius;
            name = "окружность";

            area = Area();
            perimeter = Perimeter();
        }
    }
}
