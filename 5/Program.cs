using System;
using _2._1;
namespace _2._5
{
    class Rect : Rectangle
    {

        public Rect()
        {
            length = 10;
            width = 10;
        }
        double area()
        {
            return length * width;
        }
        double perimeter()
        {
            return (length + width) * 2;
        }
    }
    class PlainRect : Rect
    {
        double startX { get; set; }
        double startY { get; set; }
        public PlainRect(double startX, double startY, double length, double width)
        {
            this.startX = startX;
            this.startY = startY;
            this.length = length;
            this.width = width;
        }
        public PlainRect()
        {
            length = 0;
            width = 0;
            startX = 0;
            startY = 0;
        }
        public bool isInside(double x, double y)
        {
            if (x > startX && y < startY && x < startX + length && y > startY - width)//向右下，默认长边平行X轴
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlainRect r = new PlainRect(10, 10, 20, 10);
            r.Area(); r.zc();
            Console.WriteLine(r.isInside(25.5, 13));
        }
    }
}
