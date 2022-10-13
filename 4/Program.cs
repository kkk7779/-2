using System;

namespace _2._4
{
    class Circle
    {
        public double r;
        public double PI = 3.14;
        public Circle(double r)
        {
            this.r = r;
        }
        public double zc()
        {
            return 2 * PI * r;
        }
        public double Area()
        {
            return PI * r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2);
            double zc = c.zc();
            double area = c.Area();
            Console.WriteLine("该圆的周长为{0}，面积为{1}", zc, area);
        }
    }
}
