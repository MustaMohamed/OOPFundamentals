using System;

namespace OOPFundamentals
{
    public class Vehicle
    {
        private string _registrationNumber;
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            // initialize field in Car class
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}