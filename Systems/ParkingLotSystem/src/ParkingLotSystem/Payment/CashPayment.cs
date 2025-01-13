using ParkingLotSystem.Interfaces;

namespace ParkingLotSystem.Payment;

public class CashPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ${amount} in cash.");
    }
}