using ParkingLotSystem.Enums;

namespace ParkingLotSystem.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string LicensePlate { get; set; }
    public VehicleType Type { get; set; }
}
