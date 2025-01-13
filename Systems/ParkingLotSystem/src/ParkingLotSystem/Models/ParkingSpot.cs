using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models;

public class ParkingSpot
{
    public int Id { get; set; }
    public ParkingSpotType Type { get; set; }
    public bool IsOccupied { get; set; }
    public bool IsElectric { get; set; }
    public int? VehicleId { get; set; }
    public Vehicle? Vehicle { get; set; }
}