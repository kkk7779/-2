using System;
using DuckFlyWithInterface;
using DuckSwimWithInterface;
using DuckQucWithInterface;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MailardDuck();
            Duck duck2 = new RedheadDuck();
            Duck duck3 = new RobberDuck();

            duck1.Display();
            duck1.performFly();
            duck1.perfomswim();
            duck1.perfomquack();
            duck2.Display();
            duck2.performFly();
            duck2.perfomswim();
            duck2.perfomquack();
            duck3.Display();
            duck3.performFly();
            duck3.perfomswim();
            duck3.perfomquack();

            duck3.changeFlyBehavior(new FlyWithRocket());
            duck3.changeQuackBehavior(new QuackwithNoWay());
            duck3.changeSwimBehavior(new SwimWithNoWay());
            duck3.Display();
            duck3.performFly();
            duck3.perfomswim();
            duck3.perfomquack();
        }
    }
}