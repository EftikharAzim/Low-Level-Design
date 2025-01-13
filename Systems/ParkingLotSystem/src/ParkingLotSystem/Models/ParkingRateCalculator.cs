// public class ParkingRateCalculator : IParkingRateCalculator
// {
//     private readonly Dictionary<VehicleType, double> _hourlyRates;

//     public ParkingRateCalculator(Dictionary<VehicleType, double> hourlyRates)
//     {
//         _hourlyRates = hourlyRates;
//     }

//     public double CalculateCharges(VehicleType vehicleType, TimeSpan duration)
//     {
//         return _hourlyRates[vehicleType] * Math.Ceiling(duration.TotalHours);
//     }
// }
