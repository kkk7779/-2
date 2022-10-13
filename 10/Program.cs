using System;
using DuckSwimWithInterface;
using DuckFlyWithInterface;
using DuckQucWithInterface;
namespace _2._10
{
    abstract class Duck
    {
        public string Name { get; set; }
        public IFlyBehavior flyBehavior { get; set; }
        public ISwimBehavior swimBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }
        public void performFly()
        {
            flyBehavior.Fly();
        }
        public void changeFlyBehavior(IFlyBehavior fl)
        {
            flyBehavior = fl;
        }
        public void Display()
        {
            Console.WriteLine("这是一只{0}", Name);
        }
        public void perfomquack()
        {
            quackBehavior.Quack();
        }
        public void changeQuackBehavior(IQuackBehavior q1)
        {
            quackBehavior = q1;
        }
        public void perfomswim()
        {
            swimBehavior.Swim();
        }
        public void changeSwimBehavior(ISwimBehavior s1)
        {
            swimBehavior = s1;
        }
    }
    class MailardDuck : Duck
    {
        public MailardDuck()
        {
            Name = "MailardDuck";
            flyBehavior = new FlyWithWings();
            swimBehavior = new SwimWithNoWay();
            quackBehavior = new QuackwithNoWay();
        }

    }
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            Name = "RedheadDuck";
            flyBehavior = new FlyWithWings();
            swimBehavior = new SwimWithNoWay();
            quackBehavior = new QuackwithNoWay();
        }
    }
    class RobberDuck : Duck
    {
        public RobberDuck()
        {
            Name = "RobberDuck";
            flyBehavior = new FlyWithNoWay();
            swimBehavior = new SwimWithNoWay();
            quackBehavior = new QuackCan();
        }
    }
}