using System;

namespace _2._1
{
    public class Rectangle
    {
        public double length { get; set; }
        public double width { get; set; }
        public Rectangle() { }
        public Rectangle(double _length, double _width)
        {
            length = _length;
            width = _width;
        }
        public void Area()
        {
            double area = length * width;
            Console.WriteLine("矩形的面积是" + area);
        }
        public void zc()
        {
            double zc = (length + width) * 2;
            Console.WriteLine("矩形的周长是" + zc);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            r.Area(); r.zc();
        }
    }
}
