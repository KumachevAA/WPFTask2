namespace WPFTask2._1.Models
{
    public class Square : Rect
    {
        public Square() : this(0)
        {

        }

        public Square(double Size) : base(Size, Size)
        {
            name = "квадрат";
        }
    }
}
