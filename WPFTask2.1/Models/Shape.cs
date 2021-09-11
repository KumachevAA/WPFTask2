using System;

namespace WPFTask2._1.Models
{
    public abstract class Shape
    {
        protected double area;
        protected string name;
        protected double perimeter;

        public Shape()
        {
            area = 0;
            perimeter = 0;
            name = "без названия";
        }

        public void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Имя: {name}" + Environment.NewLine +
                $"Площадь: {area}" + Environment.NewLine +
                $"Периметр: {perimeter}";
        }
    }
}
