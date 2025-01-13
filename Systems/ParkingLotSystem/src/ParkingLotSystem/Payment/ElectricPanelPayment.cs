using ParkingLotSystem.Interfaces;

namespace ParkingLotSystem.Payment;

public class ElectricPanelPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ${amount} in cash.");
    }
}