using System;
using System.Linq;
using System.Reflection;

namespace test4fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1("Hello, world");
            Task1("Hel");

            Task2();

            Console.ReadLine();
        }

        private static void Task1(string text)
        {
            var modifiedText = text.Collapse();

            Console.WriteLine($"{text}\t {modifiedText}");
        }

        private static unsafe void Task2()
        {
            var myProduct = new Product
            {
                Name = "test name"
            };

            //CompileTime error
            //myProduct._id

            Console.WriteLine($"{myProduct.Id}\t{myProduct.Name}");
            myProduct.GetType().GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance)?.SetValue(myProduct, new Guid());
            Console.WriteLine($"{myProduct.Id}\t{myProduct.Name}");

            myProduct.GetType().GetProperty("Name").SetValue(myProduct, "new name");
            Console.WriteLine($"{myProduct.Id}\t{myProduct.Name}");

            Console.WriteLine(Product.ProductType);
            fixed (char* ps = Product.ProductType)
            {
                var tempString = new string(Product.ProductType);
                for (var i = 0; i < Product.ProductType.Length; i++)
                {
                    ps[i] = tempString.ElementAt(Product.ProductType.Length - i - 1);
                }
            }

            Console.WriteLine(Product.ProductType);
        }
    }
}
