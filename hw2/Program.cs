using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = PopulateArray();

            Func<Motorcycle, bool> filter1 = m => m.Odometer > 50000;
            Func<Motorcycle, bool> filter2 = m => string.Equals(m.MadeIn, "China", StringComparison.InvariantCultureIgnoreCase);
            Func<Motorcycle, bool> filter3 = m => m.Odometer > 25000 && string.Equals(m.MadeIn, "Japan", StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(array.MyFirstOrDefault(filter1).Odometer);
            Console.WriteLine(array.MyFirstOrDefault(filter2).Odometer);
            Console.WriteLine(array.MyFirstOrDefault(filter3).Odometer);

            Console.ReadLine();
        }

        static Motorcycle[] PopulateArray()
        {
            Motorcycle[] arr = new Motorcycle[5];

            arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
            arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
            arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
            arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
            arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };

            return arr;
        }
    }
}
