namespace CarLib
{
    public interface ICar
    {
        string Name { get; set; }
        int Velocity { get; }
        int Fuel { get; }

        void AddFuel( string fuelType, int liters );
        void DecreaseVelosity( int step );
        void IncreaseVelosity( int step );
    }
}