using System;

namespace hw2
{
    public static class MotorcycleExtensions
    {
        public static Motorcycle MyFirstOrDefault(this Motorcycle[] list, Func<Motorcycle, bool> filter)
        {
            foreach (var item in list)
            {
                if (filter.Invoke(item))
                {
                    return item;
                }
            }

            return new Motorcycle();
        }
    }
}
