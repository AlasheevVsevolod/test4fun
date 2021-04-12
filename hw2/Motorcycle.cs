using System;

namespace hw2
{
    public class Motorcycle
    {
        public Guid Id { get; private set; }
        public string Model { get; set; }
        public int Odometer { get; set; }
        public string MadeIn { get; set; }
    }
}
