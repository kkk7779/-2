using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSwimWithInterface
{
    interface ISwimBehavior
    {
        public void Swim();
    }
    public class SwimWithNoWay : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("不会游泳！");
        }
    }
    public class SwimCan : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("会游泳！");
        }
    }
}