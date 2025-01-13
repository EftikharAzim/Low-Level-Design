// public class ParkingLot
// {
//     public string Name { get; }
//     private readonly List<ParkingFloor> _floors;
//     private readonly IParkingRateCalculator _rateCalculator;

//     public ParkingLot(string name, List<ParkingFloor> floors, IParkingRateCalculator rateCalculator)
//     {
//         Name = name;
//         _floors = floors;
//         _rateCalculator = rateCalculator;
//     }

//     public ParkingTicket ParkVehicle(Vehicle vehicle)
//     {
//         foreach (var floor in _floors)
//         {
//             var spot = floor.FindAvailableSpot(vehicle.Type);
//             if (spot != null && spot.AssignVehicle(vehicle))
//             {
//                 return new ParkingTicket(Guid.NewGuid().ToString(), vehicle, spot as ParkingSpot);
//             }
//         }
//         throw new InvalidOperationException("No available spots for the vehicle type.");
//     }

//     public double ReleaseVehicle(ParkingTicket ticket)
//     {
//         if (ticket.Spot.RemoveVehicle())
//         {
//             TimeSpan duration = DateTime.Now - ticket.StartTime;
//             double charges = _rateCalculator.CalculateCharges(ticket.Vehicle.Type, duration);
//             ticket.CloseTicket(charges);
//             return charges;
//         }
//         throw new InvalidOperationException("Error removing the vehicle from the spot.");
//     }
// }