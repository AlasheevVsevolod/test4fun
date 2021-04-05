using System;

namespace test4fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1("Hello, world");
            Task1("Hel");

            Console.ReadLine();
        }

        private static void Task1(string text)
        {
            var modifiedText = text.Collapse();

            Console.WriteLine($"{text}\t {modifiedText}");
        }
    }
}
