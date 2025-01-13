public class ParkingTicket
{
    public string Id { get; }
    public Vehicle Vehicle { get; }
    public ParkingSpot Spot { get; }
    public DateTime StartTime { get; }
    public DateTime? EndTime { get; private set; }
    public double TotalCost { get; private set; }
    public TicketStatus Status { get; private set; }

    public ParkingTicket(string id, Vehicle vehicle, ParkingSpot spot)
    {
        Id = id;
        Vehicle = vehicle;
        Spot = spot;
        StartTime = DateTime.Now;
        Status = TicketStatus.Active;
    }

    public void CloseTicket(double totalCost)
    {
        EndTime = DateTime.Now;
        TotalCost = totalCost;
        Status = TicketStatus.Paid;
    }
}