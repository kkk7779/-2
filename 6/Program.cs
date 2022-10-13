using System;

namespace _2._6
{
    abstract public class animal
    {
        public abstract void voice();
    }
    public class cat : animal
    {
        public override void voice()
        {
            Console.WriteLine("小猫喵喵叫");
        }
    }
    public class pig : animal
    {
        public override void voice()
        {
            Console.WriteLine("小猪哼哼叫");
        }
    }
    public class dog : animal
    {
        public override void voice()
        {
            Console.WriteLine("小狗汪汪叫");
        }
    }
    class Store
    {
        public animal getInstance(string name)
        {
            if (name == "dog")
            {
                return new dog();
            }
            if (name == "pig")
            {
                return new pig();
            }
            return new cat();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            animal a = s.getInstance("dog");
            a.voice();
        }
    }
}
