namespace ParkingLotSystem.Models;
public class ParkingTicket
{
    public int Id { get; set; }
    public int SpotId { get; set; }
    public ParkingSpot Spot { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public double? TotalCost { get; set; }
}
