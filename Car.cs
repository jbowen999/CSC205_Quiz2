using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_Quiz2
{
    internal class Car
    {
        private string _vin;
        private string _make;
        private string _model;
        private int _mileage;

        //public int Mileage { get { return _mileage; } }

        public Car(string vin, string make, string model)
        {
            _vin = vin;
            _make = make;
            _model = model;
        }
        public void Drive(int miles)
        {
        _mileage += miles; 
        }
        public void Display()
        {
            Console.WriteLine($"Make: {_make}");
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Mileage: {_mileage}");
            Console.WriteLine($"Vin: {_vin}");

        }
    }
}
