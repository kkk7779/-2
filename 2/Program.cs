using System;

namespace _2._2
{
    class Employee
    {
        private String name;
        private int age;
        private string sex;
        private double salary;

        public Employee()
        {
        }

        public Employee(String name, int age, string sex, double salary)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.salary = salary;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getSex()
        {
            return sex;
        }

        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
        public double getSalary()
        {
            return salary;
        }
        public void show()
        {
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("性别:" + sex);
            Console.WriteLine("薪水:" + salary);
        }
    }
    class Progame
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.setAge(18);
            e.setName("byx");
            e.setSalary(6666.66);
            e.setSex("男");
            Console.WriteLine(e.getSalary());
            e.show();
        }
    }
}
