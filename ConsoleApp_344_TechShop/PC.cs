using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_344_TechShop
{
    internal class PC: Device
    {
        public PC()
        {
            Console.WriteLine("PC was created");
        }

        public PC(string Name, Brand Brand, decimal Price, uint Quantity, uint RAM)
            : base(Name, Brand, Price, Quantity, RAM)
        {
            Console.WriteLine("PC was created");
        }

        public override void Sale()
        {
            _price *= 0.8m;
        }

        public override void Sale(decimal Percentage)
        {
            Price -= Price *= Percentage;
            Console.WriteLine("Override sale.");
        }
    }
}
