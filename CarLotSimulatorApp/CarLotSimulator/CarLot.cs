﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<CarLot> AListOfCars { get; set; } = new List<CarLot>();
    }
}
  //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        