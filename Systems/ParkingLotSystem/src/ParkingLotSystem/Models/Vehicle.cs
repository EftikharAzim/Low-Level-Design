public class Vehicle
{
    public string LicensePlate { get; }
    public VehicleType Type { get; }

    public Vehicle(string licensePlate, VehicleType type)
    {
        LicensePlate = licensePlate;
        Type = type;
    }
}