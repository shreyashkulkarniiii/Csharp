using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    using System;
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual decimal GetDiscountedPrice()
        {
            return Price;
        }
    }
    public class ElectronicProduct : Product
    {
        public ElectronicProduct(string name, decimal price) : base(name, price) { }
        public override decimal GetDiscountedPrice()
        {
            return Price * 0.90m;
        }
    }

    public class ClothingProduct : Product
    {
        public ClothingProduct(string name, decimal price) : base(name, price) { }
        public override decimal GetDiscountedPrice()
        {
            return Price * 0.80m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product electronicProduct = new ElectronicProduct("Laptop", 1000);
            Console.WriteLine($"Product: {electronicProduct.Name}, " +
                              $"Original Price: {electronicProduct.Price:C}, " +
                              $"Discounted Price: {electronicProduct.GetDiscountedPrice():C}");

            Product clothingProduct = new ClothingProduct("T-Shirt", 30);
            Console.WriteLine($"Product: {clothingProduct.Name}, " +
                              $"Original Price: {clothingProduct.Price:}, " +
                              $"Discounted Price: {clothingProduct.GetDiscountedPrice():C}");
        }
    }
}
