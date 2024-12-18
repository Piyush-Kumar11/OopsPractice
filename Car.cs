using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPractice
{
    internal class Car: Vehicle
    {
        public string brand { get; set; }
        public string color { get; set; }
        public double price { get; set; }


        //public Car(string brand, string color, double price)
        //{
        //    this.brand = brand;
        //    this.color = color;
        //    this.price = price;
        //}

        public void DisplayCar()
        {
            Console.WriteLine($"Car => Brand: {brand},color: {color}, price: {price}");
        }

        public void Start()
        {
            Console.WriteLine("Car has started!");
        }

        public void Drive()
        {
            Console.WriteLine("Car is moving");
        }

        public void Brake()
        {
            Console.WriteLine("Car has Stopped!");
        }
    }
}
