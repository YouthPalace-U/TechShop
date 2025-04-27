using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_344_TechShop
{
    abstract class Device : Product
    {
        protected uint _ram;

        public Device()
        {
            Console.WriteLine("Device was created");
        }

        public Device(string Name, Brand Brand, decimal Price, uint Quantity, uint RAM)
            : base(Name, Brand, Price, Quantity)
        {
            this._ram = RAM;
            Console.WriteLine("Device was created");
        }

        public uint RAM
        {
            get => _ram;
            set => _ram = value;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Brand: {Brand}, " +
                $"Price:{Price}, RAM: {RAM}.");
        }

        public virtual void Sale(decimal Percentage)
        {
            Price -= Price *= Percentage;
        }

        abstract public void Sale();
    }
}