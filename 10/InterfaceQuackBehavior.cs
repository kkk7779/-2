using System;
using System.Collections.Generic;
using System.Text;

namespace DuckQucWithInterface
{
    interface IQuackBehavior
    {
        public void Quack();
    }
    public class QuackwithNoWay : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("不会叫！");
        }
    }
    public class QuackCan : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("会叫！");
        }
    }
}
