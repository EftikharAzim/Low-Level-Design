public class CreditCard : Card, IPaymentMethod
{
    public CreditCard(string cardNo, string userName) : base(cardNo, userName)
    {
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paying ${amount} using credit card {GetCardNo()}.");
    }
}