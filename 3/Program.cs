using System;

namespace _2._3
{
    class MyMath
    {
        public double jia(double a, double b)
        {
            return a + b;
        }
        public double jian(double a, double b)
        {
            return a - b;
        }
        public double cheng(double a, double b)
        {
            return a * b;
        }
        public double chu(double a, double b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            double sum = m.jia(1, 2);
            double cha = m.jian(1, 2);
            double ji = m.cheng(1, 2);
            double shang = m.chu(1, 2);
            Console.WriteLine("和：" + sum + " 差：" + cha + " 积：" + ji + " 商：" + shang);
        }
    }
}
