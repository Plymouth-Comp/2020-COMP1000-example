using System;

namespace Exercise
{
    public class Program
    {
        public string SayHello()
        {
            return "Hello World!";
        }
        public string SayGoodBye()
        {
            return ("Hello World!");
        }


        static void Main(string[] args)
        {
            Program prog = new Program();

            Console.WriteLine(prog.SayHello());
            Console.WriteLine(prog.SayGoodBye());
        }
    }
}
