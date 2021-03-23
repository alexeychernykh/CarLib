using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Car : BaseCar, ICar
    {
        private int _velocity;

        public string Name { get; set; }

        public int Velocity { get { return _velocity; } }

        public void IncreaseVelosity( int step )
        {
            _velocity += step;
        }

        public void DecreaseVelosity( int step )
        {
            if ( _velocity - step >= 0 )
            {
                _velocity -= step;
            }
        }

        protected override bool IsCorrectFuel( string fuelType )
        {
            return true;
        }
    }
}
