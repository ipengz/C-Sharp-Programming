using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Car
    {
        // member variable
        // private hides the variable from other class
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        public static int NumberOfCars = 0;

        // property
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if (_isLuxury)
                {
                    return _brand + "- is Luxury";
                }else
                {
                    return _brand;
                }
            }

            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You have entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
             }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public Car(string model, string brand, bool isLuxury) {

            NumberOfCars++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;

            Console.WriteLine($"A {brand} of the model {model} has been created");
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm {Model} and I'm driving");
        }

        
    }
}
