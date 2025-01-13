public class Card
{
    private string _cardNo;
    private string _userName;

    public Card(string cardNo, string userName)
    {
        _cardNo = cardNo;
        _userName = userName;
    }

    public string GetCardNo()
    {
        return _cardNo;
    }

    public string GetUserName()
    {
        return _userName;
    }
}