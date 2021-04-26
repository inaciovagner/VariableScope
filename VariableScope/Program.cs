using System;
namespace CsharpPrograms
{
    class Program
    {
        public int i;

        public Program(int x)

        {
            i = x;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program(x);
            Console.WriteLine(obj.i);
        }
    }
}