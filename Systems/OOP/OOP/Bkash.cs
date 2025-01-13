public class Bkash : IPaymentMethod
{
    private readonly string _phoneNo;

    public Bkash(string phoneNo)
    {
        _phoneNo = phoneNo;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paying ${amount} using bKash.");
    }
}