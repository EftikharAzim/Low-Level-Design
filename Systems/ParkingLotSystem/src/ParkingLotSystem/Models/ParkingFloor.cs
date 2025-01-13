// public class ParkingFloor
// {
//     public string Name { get; }
//     private readonly List<IParkingSpot> _spots;

//     public ParkingFloor(string name, List<IParkingSpot> spots)
//     {
//         Name = name;
//         _spots = spots;
//     }

//     public IParkingSpot FindAvailableSpot(VehicleType vehicleType)
//     {
//         foreach (var spot in _spots)
//         {
//             if (spot.IsAvailable && IsSpotCompatible(spot, vehicleType))
//                 return spot;
//         }
//         return null;
//     }

//     private bool IsSpotCompatible(IParkingSpot spot, VehicleType vehicleType)
//     {
//         return (vehicleType == VehicleType.Bike && spot is ParkingSpot { Type: ParkingSpotType.Small }) ||
//                (vehicleType == VehicleType.Car && spot is ParkingSpot { Type: ParkingSpotType.Medium }) ||
//                (vehicleType == VehicleType.Truck && spot is ParkingSpot { Type: ParkingSpotType.Large });
//     }
// }