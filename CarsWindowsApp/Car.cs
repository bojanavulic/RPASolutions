using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWindowsApp
{
    public class Car
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int? Mileage { get; set; }

        public int? NumberOfDoors { get; set; }

        public string CountryOfOrigin { get; set; }

        public Car(string name, string color, int? mileage, int? numberOfDoors, string countryOfOrigin)
        {
            this.Name = name;
            this.Color = color;
            this.Mileage = mileage;
            this.NumberOfDoors = numberOfDoors;
            this.CountryOfOrigin = countryOfOrigin;
        }
    }   
}
