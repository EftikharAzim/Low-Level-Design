public class PaymentService
{
    private Dictionary<string, IPaymentMethod> _paymentMethods = new Dictionary<string, IPaymentMethod>();

    public void AddPaymentMethod(string cardNo, IPaymentMethod paymentMethod)
    {
        _paymentMethods.Add(cardNo, paymentMethod);
    }

    public void MakePayment(string cardNo, double amount)
    {
        if (_paymentMethods.ContainsKey(cardNo))
        {
            var pm = _paymentMethods.GetValueOrDefault(cardNo);
            pm?.Pay(amount);
        }
        else
        {
            Console.WriteLine("Payment method not found.");
        }
    }
}