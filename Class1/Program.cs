using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport;
using Mathmatic;


namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car MyCar = new Car()
            {
                name = "BMW",
                color = "Blue",
                NoOfSeats = 5,
                IsHachback = false
            };
            Console.WriteLine($"Car Name: {MyCar.name}");
            Console.WriteLine($"Car Color: {MyCar.color}");
            Console.WriteLine($"Number of Seats: {MyCar.NoOfSeats}");
            Console.WriteLine($"Is Hatchback: {MyCar.IsHachback}");
            int currentSpeed = 50;
            Console.WriteLine($"Current Speed: {currentSpeed}");
            currentSpeed = MyCar.Accelerate(currentSpeed);
            Console.WriteLine($"Speed after acceleration: {currentSpeed}");
            currentSpeed = MyCar.Brake(currentSpeed);
            Console.WriteLine($"Speed after braking: {currentSpeed}");
            Console.ReadLine();*/

            MathOperation obj1= new MathOperation();
            obj1.Sum();
            obj1.sum2(50, 80);

        }
    }
}
