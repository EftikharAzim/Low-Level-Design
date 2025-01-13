public class Nagad : IPaymentMethod
{
    private readonly string _phoneNo;

    public Nagad(string phoneNo)
    {
        _phoneNo = phoneNo;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paying ${amount} using nagad.");
    }
}