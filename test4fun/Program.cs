using System;

namespace test4fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Console.ReadLine();
        }

        private static void Task1()
        {
            var text = "Hello, world";
            var modifiedText = text.Collapse();

            Console.WriteLine($"{text}\t {modifiedText}");
        }
    }
}
