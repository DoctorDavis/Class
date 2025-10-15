// Author:  Jim Davis
// Created: October 1, 2025
// Updated: October 9, 2025
// Description: Car Class to support the CarViewer program.


using System;

namespace CarViewer
{
    /// <summary>
    /// Car Class, when done I confirmed through Co-Pilot
    /// it wanted me to compress the code by using auto-properties
    /// i did it the way you showed in slides... so thank you.
    /// </summary>
    public class Car
    {
        // Private variable for the car's make
        private string carMake = string.Empty;

        // Public property for the car's make
        // used in other parts of the program
        public string Make
        {
            get 
            { 
                return carMake; 
            }
            set { carMake = value; }
        }

        // Private variable for the car's model
        private string carModel = string.Empty;

        // Public property for the car's model
        // used in other parts of the program
        public string Model
        {
            get 
            { 
                return carModel; 
            }
            set 
            { 
                carModel = value; 
            }
        }

        // Private variable for the car's year
        private int carYear = 0000;

        // Public property for the car's year
        // used in other parts of the program
        public int Year
        {
            get 
            { 
                return carYear; 
            }
            set 
            { 
                carYear = value; 
            }
        }

        // Private variable for the car's price
        private decimal carPrice = 0m;

        // Public property for the car's price
        // used in other parts of the program
        public decimal Price 
        { 
            get 
            { 
                return carPrice; 
            }
            set 
            { 
                carPrice = value;
            }
        }

        // Private variable for whether the car is new
        private bool carIsNew = true;

        // Public property for whether the car is new or used
        // used in other parts of the program
        public bool IsNew
        {
            get 
            { 
                return carIsNew; 
            }
            set 
            { 
                carIsNew = value; 
            }
        }

        // Default constructor
        public Car() { }

        // Parametrized constructor to initialize all properties
        public Car(string make, string model, int year, decimal price, bool isNew)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            IsNew = isNew;
        }
    }
}
