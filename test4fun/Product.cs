using System;

namespace test4fun
{
    class Product
    {
        public const string ProductType = "Phone";
        private Guid _id;
        public Guid Id { get { return _id; } }
        public string Name { get; set; }
        public Product()
        {
            _id = Guid.NewGuid();
        }
    }
}
