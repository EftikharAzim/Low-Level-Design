public class DebitCard : Card, IPaymentMethod
{
    public DebitCard(string cardNo, string userName) : base(cardNo, userName)
    {
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paying ${amount} using debit card {GetCardNo()}.");
    }
}