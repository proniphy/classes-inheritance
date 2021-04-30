using System;
using System.Collections.Generic;
using System.Text;

namespace MachineBuilder.machines
{
    public class Automobile :Vehicle
    {
        private int power;
        private int price;
        public int Power { get;}
        public int Price { get;}
        public Automobile(int power, int price, int wheels) :base(wheels)
        {
            Power = power;
            Price = price;
        }

        public bool IsLowTax(int power)
        {
            if (power <= 101)
            {
                Console.WriteLine("The tax for the car will be low");
                return true;
            }
            else
            {
                Console.WriteLine("The tax for the car will be high");
                return false;
            }
        }

        public double PricePerHorsePower(int price, int power)
        {
            price = this.Price;
            power = this.Power;
            double result = price / power;
            Console.WriteLine("The cost per 1 horse power will be: " + result + " EUR");
            return result;
        }
    }
}
