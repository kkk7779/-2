using System;

namespace _2._7
{
    public abstract class Animal
    {
        public string name;
        public Animal() { }
        public Animal(string name) { this.name = name; }
        public abstract void enjoy();
    }
    public class Cat : Animal
    {
        String eyesColor;
        public Cat() { }
        public Cat(String eyesColor, String name)
        {
            this.eyesColor = eyesColor;
            this.name = name;
        }
        public override void enjoy()
        {
            Console.WriteLine("喵~,我叫" + name + ",我的眼睛是" + eyesColor + ",我很快乐");
        }
    }
    public class Dog : Animal
    {
        string furColor;
        public Dog() { }
        public Dog(string furColor, string name)
        {
            this.furColor = furColor;
            this.name = name;
        }
        public override void enjoy()
        {
            Console.WriteLine("汪~,我叫" + name + ",我的皮肤是" + furColor + ",我很快乐");
        }
    }
    public class Lady
    {
        String name;
        Animal pet;
        public Lady() { }
        public Lady(String name, Animal pet)
        {
            this.name = name;
            this.pet = pet;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public Animal getPet()
        {
            return pet;
        }
        public void setPet(Animal pet)
        {
            this.pet = pet;
        }
        public void myPetEnjoy()
        {
            pet.enjoy();
            Console.WriteLine("我叫" + this.name + ",我的宠物很高兴,我也很高兴");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("黄皮", "旺财");
            Cat c = new Cat("黑白", "小哆啦");
            Lady wang = new Lady("王女士", d);
            Lady zhang = new Lady("张女士", c);
            wang.myPetEnjoy();
            zhang.myPetEnjoy();
        }
    }
}
