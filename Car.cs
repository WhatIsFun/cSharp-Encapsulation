using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_PropertiesAndEncapsulation
{
    internal class Car
    {
        public string model { get; }
        public string year { get; private set; }
        public string color { get; set; }
        private bool IsEngineRunning = false;


        public Car(string model, string year, string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;
        }

        //public void LockButtonPressed()
        //{
        //    isDoorLocked = true;
        //}

        //public void UnlockButtonPressed()
        //{
        //    isDoorLocked = false;
        //}

        //public bool StartEngine()
        //{
        //    IsEngineRunning = true;
        //    return IsEngineRunning;
        //}

        //public bool StopEngine()
        //{
        //    IsEngineRunning = false;
        //    return IsEngineRunning;
        //}

        //public void moveCar()
        //{
        //    if (IsEngineRunning)
        //    {
        //        this.LockButtonPressed();
        //        Console.WriteLine("Car is moving");
        //    }
        //    else
        //    {
        //        this.UnlockButtonPressed();
        //        Console.WriteLine("Car is not moving.");
        //    }

        //}
    }
}
