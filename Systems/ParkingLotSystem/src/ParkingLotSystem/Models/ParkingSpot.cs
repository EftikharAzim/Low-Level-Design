public class ParkingSpot : IParkingSpot
{
    public string Id { get; }
    public ParkingSpotType Type { get; }
    public bool IsAvailable => !IsOccupied;
    private bool IsOccupied { get; set; }
    private Vehicle ParkedVehicle { get; set; }

    public ParkingSpot(string id, ParkingSpotType type)
    {
        Id = id;
        Type = type;
        IsOccupied = false;
    }

    public bool AssignVehicle(Vehicle vehicle)
    {
        if (IsOccupied) return false;
        ParkedVehicle = vehicle;
        IsOccupied = true;
        return true;
    }

    public bool RemoveVehicle()
    {
        if (!IsOccupied) return false;
        ParkedVehicle = null;
        IsOccupied = false;
        return true;
    }
}