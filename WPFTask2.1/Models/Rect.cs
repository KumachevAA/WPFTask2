namespace WPFTask2._1.Models
{
    public class Rect : Shape
    {
        protected double width;
        protected double height;

        protected double Area()
        {
            return width * height;
        }

        protected double Perimeter()
        {
            return 2 * (width + height);
        }

        public Rect() : this(0, 0)
        {

        }

        public Rect(double Width, double Height)
        {
            width = Width;
            height = Height;
            name = "прямоугольник";

            area = Area();
            perimeter = Perimeter();
        }
    }
}
