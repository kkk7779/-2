using System;

namespace _2._8
{
    public interface InterfaceA
    {
        void printCapitalLetter();
    }
    public interface InterfaceB
    {
        void printLowercaseLetter();
    }
    public class Print : InterfaceA, InterfaceB
    {

        public void printLowercaseLetter()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }
        }
        public void printCapitalLetter()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceA a = new Print();
            a.printCapitalLetter();
            InterfaceB b = new Print();
            b.printLowercaseLetter();

        }
    }
}
