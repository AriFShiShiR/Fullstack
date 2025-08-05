using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport

{
    internal class Car
    {
        public string? name { get; set; }

        public string? color { get; set; }

        public int NoOfSeats { get; set; }

        public bool IsHachback { get; set; }

        // Method

        public int Accelerate(int speed)
        {

            return speed + 10;
        }
        public int Brake(int speed)
        {
            if (speed < 10)
            {
                return 0; // Prevent negative speed
            }
            return speed - 10;
        }

        // Move Main method outside of Car class
    }

}
