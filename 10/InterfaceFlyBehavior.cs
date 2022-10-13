using System;

namespace DuckFlyWithInterface
{
    interface IFlyBehavior
    {
        public void Fly();
    }
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("用翅膀飞！");
        }
    }
    public class FlyWithNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("不能飞！");
        }
    }
    public class FlyWithRocket : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("乘坐火箭飞！");
        }
    }
}