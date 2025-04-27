using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_344_TechShop
{
    enum Brand { Acer, Asus, Lenovo, Microsoft }

    internal class Laptop : Device
    {
        public Laptop()
        {
            Console.WriteLine("Laptop was created");
        }

        public Laptop(string Name, Brand Brand, decimal Price, uint Quantity, uint RAM)
            : base (Name, Brand, Price, Quantity, RAM)
        {
            Console.WriteLine("Laptop was created");
        }

        public override void Sale()
        {
            _price *= 0.9m;
        }
    }
}
