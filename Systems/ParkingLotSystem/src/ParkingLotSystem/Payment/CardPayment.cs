using ParkingLotSystem.Interfaces;

namespace ParkingLotSystem.Payment;

public class CardPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ${amount} using credit card.");
    }
}