internal class Program
{
    private static void Main(string[] args)
    {
        PaymentService paymentService = new PaymentService();
        Console.WriteLine("Welcome to Payment Service");
        Console.WriteLine("Please select payment method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Debit Card");
        Console.WriteLine("3. bKash");
        Console.WriteLine("4. Nagad");

        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter card or mobile number:");
        string cardOrMobileNo = Console.ReadLine();
        Console.WriteLine("Enter user name:");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter amount:");
        string amount = Console.ReadLine();

        if (choice == 1)
        {
            CreditCard creditCard = new CreditCard(cardOrMobileNo, userName);
            paymentService.AddPaymentMethod(cardOrMobileNo, creditCard);
            paymentService.MakePayment(cardOrMobileNo, double.Parse(amount));
        }
        else if (choice == 2)
        {
            DebitCard debitCard = new DebitCard(cardOrMobileNo, userName);
            paymentService.AddPaymentMethod(cardOrMobileNo, debitCard);
            paymentService.MakePayment(cardOrMobileNo, double.Parse(amount));
        }
        else if (choice == 3)
        {
            Bkash bkash = new Bkash(cardOrMobileNo);
            paymentService.AddPaymentMethod(cardOrMobileNo, bkash);
            paymentService.MakePayment(cardOrMobileNo, double.Parse(amount));
        }
        else if (choice == 4)
        {
            Nagad nagad = new Nagad(cardOrMobileNo);
            paymentService.AddPaymentMethod(cardOrMobileNo, nagad);
            nagad.Pay(double.Parse(amount));
        }

        Console.WriteLine("Payment successful.");
    }
}