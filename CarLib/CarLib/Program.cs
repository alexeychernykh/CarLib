using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Program
    {
        public void Main()
        {
            ICar car = new Car();
            car.Name = "Mercedes";
            car.AddFuel( "98", 30 );
            car.IncreaseVelosity( 50 );
            car.DecreaseVelosity( 5 );

            Console.WriteLine( $"Car: {car.Name} Velosity: {car.Velocity} Fuel: {car.Fuel}" );
        }
    }
}
