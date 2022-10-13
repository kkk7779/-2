using System;

namespace _2._9
{
    interface A
    {
        double area();
    }
    interface B
    {
        void setColor(String c);
    }
    interface C : A, B
    {
        void getVolume();
    }
    public class Cylinder : C
    {
        double radius;
        double height;
        double PI = 3.14;
        String color;
        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }
        public double area()
        {
            return PI * radius * radius;
        }
        public void setColor(String c)
        {
            color = c;
            Console.WriteLine("形状的颜色：" + color);
        }
        public void getVolume()
        {
            Console.WriteLine("圆柱体的体积：" + Math.Round(area() * height, 3));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder(3, 5);
            c.setColor("红色");
            c.getVolume();
        }
    }
}
