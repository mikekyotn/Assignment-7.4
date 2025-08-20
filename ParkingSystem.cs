using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._4
{
    //ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class.
    //The number of slots for each parking space are given as part of the constructor.
    internal class ParkingSystem
    {
        public int Big { get; set; } //represented by 1
        public int Medium { get; set; } //represented by 2
        public int Small { get; set; } // represented by 3
        public ParkingSystem(int big, int medium, int small)
        {
            Big = big;
            Medium = medium;
            Small = small;
        }


        //bool addCar(int carType) Checks whether there is a parking space of carType for the car
        //that wants to get into the parking lot. carType can be of three kinds: big, medium,
        //or small, which are represented by 1, 2, and 3 respectively. A car can only park in a
        //parking space of its carType. If there is no space available, return false,
        //else park the car in that size space and return true.
        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (Big > 0)
                    {
                        Big--;
                        return true;
                    }
                    break;
                case 2:
                    if (Medium > 0)
                    {
                        Medium--;
                        return true;
                    }
                    break;
                case 3:
                    if (Small > 0)
                    {
                        Small--;
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
