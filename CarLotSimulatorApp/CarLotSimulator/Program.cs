﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
           var firstCar = new Car();
            firstCar.Make = "Ford";
            firstCar.Model = "Fusion";
            firstCar.Year = 2014;
            firstCar.IsDriveable = true;
            firstCar.EngineNoise = "Vroom";

            var carLot = new List<Car>(); 
            carLot.Add(firstCar);
            Console.WriteLine($"Info on {firstCar.Make}");
            Console.WriteLine($"Engine Noise:  {firstCar.MakeEngineNoise()}");
            Console.WriteLine($"Horn Noise:  {firstCar.MakeHonkNoise()}");
            Console.WriteLine();

            var secondCar = new Car() {Make = "Chevy", Model= "Bel-Air", Year = 1956, IsDriveable = false, EngineNoise = "broken" };
            carLot.Add(secondCar);
            Console.WriteLine($"Info on {secondCar.Make}");
            Console.WriteLine($"Engine Noise: {secondCar.MakeEngineNoise()}");
            Console.WriteLine($"Horn Noise: {secondCar.MakeHonkNoise()}");
            Console.WriteLine();   

            Car thirdCar = new Car()
            {
                Make = "Cadillac",
                Model= "CTS5",
                Year = 1962,
                IsDriveable = true,
                EngineNoise = "Vroom"
            };
            carLot.Add(thirdCar);
            Console.WriteLine($"Info on {thirdCar.Make}");
            Console.WriteLine($"Engine Noise: {thirdCar.MakeEngineNoise()}");
            Console.WriteLine($"Horn Noise: {thirdCar.MakeHonkNoise()}");
            Console.WriteLine();
            //*************BONUS*************//
            
            foreach (var car in carLot)
            {
                Console.WriteLine();
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine();
                Console.WriteLine($"Model: { car.Model}");
            }
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
