public class ParkingRate
{
    private Dictionary<VehicleType, double> HourlyRates { get; set; }

    public ParkingRate()
    {
        HourlyRates = new Dictionary<VehicleType, double>
            {
                { VehicleType.Bike, 10 },
                { VehicleType.Car, 20 },
                { VehicleType.Truck, 30 }
            };
    }

    public double CalculateCharges(VehicleType vehicleType, TimeSpan duration)
    {
        return HourlyRates[vehicleType] * duration.TotalHours;
    }
}