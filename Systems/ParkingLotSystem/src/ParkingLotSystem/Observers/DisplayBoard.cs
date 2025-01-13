using ParkingLotSystem.Enums;
using ParkingLotSystem.Models;

namespace ParkingLotSystem.Observers;
public class DisplayBoard
{
    private readonly Dictionary<ParkingSpotType, int> _availableSpots = new();

    public void UpdateSpotAvailability(ParkingSpotType type, int availableCount)
    {
        _availableSpots[type] = availableCount;
        ShowAvailability();
    }

    public void ShowAvailability()
    {
        Console.WriteLine("Display Board:");
        foreach (var spot in _availableSpots)
        {
            Console.WriteLine($"{spot.Key}: {spot.Value} spots available");
        }
    }
}
