using ParkingLotSystem.Enums;
using ParkingLotSystem.Models;

namespace ParkingLotSystem.Manager;

public class ParkingSpotManager
{
    public ParkingSpot? AssignSpot(Vehicle vehicle)
    {
        var spotType = GetSpotTypeForVehicle(vehicle.Type);
        var availableSpot = ParkingSpots.FirstOrDefault(s =>
            s.Type == spotType && !s.IsOccupied);

        if (availableSpot != null)
        {
            availableSpot.IsOccupied = true;
            availableSpot.VehicleId = vehicle.Id;
        }

        return availableSpot;
    }

    public void FreeSpot(int spotId)
    {
        var spot = ParkingSpots.FirstOrDefault(s => s.Id == spotId);
        if (spot != null)
        {
            spot.IsOccupied = false;
            spot.VehicleId = null;
        }
    }

    private SpotType GetSpotTypeForVehicle(VehicleType vehicleType)
    {
        return vehicleType switch
        {
            VehicleType.Car => SpotType.Compact,
            VehicleType.Truck => SpotType.Large,
            VehicleType.Motorcycle => SpotType.Motorcycle,
            VehicleType.Electric => SpotType.Electric,
            _ => throw new ArgumentException("Unsupported vehicle type.")
        };
    }
}
