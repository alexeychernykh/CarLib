using System;

namespace CarLib
{
    public abstract class BaseCar
    {
        protected int FuelLiters = 0;

        public int Fuel { get { return FuelLiters; } }

        public void AddFuel( string fuelType, int liters )
        {
            if ( liters < 0 )
            {
                throw new ArgumentException( "You can not get fuel back!" );
            }

            if ( !IsCorrectFuel( fuelType ) )
            {
                throw new InvalidOperationException( "" );
            }

            FuelLiters += liters;
        }

        protected abstract bool IsCorrectFuel( string fuelType );
    }
}
