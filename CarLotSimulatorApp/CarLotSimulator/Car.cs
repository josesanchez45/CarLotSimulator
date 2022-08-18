using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise()
        {
            if (IsDriveable == false)
            {
                return "This engine doesn't work";
            }
            else
            {
                return "Vroom Vroom";
            }

        }
        public string MakeHonkNoise()
        {
            if (IsDriveable == false)
            {
                return "This car doesn't work";
            }
            else
            {
                return "beep beep";
            }
        }
    }

}       //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
