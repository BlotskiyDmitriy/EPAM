﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Enum;

namespace TaxiStation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> taxiCarsPoll = new List<Car>
            {
                new ElectroCar(Brand.Audi, TypeCar.Sedan, new Engine(244), 21000, "Red", 
                "1111AB","A8", 0, 320, 2000, 60, 600)
            };
        }
    }
}
