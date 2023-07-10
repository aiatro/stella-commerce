namespace Stella_Commerce.web.resource
{
    public class Card
    {
        public string CardNum { get; set; }
        public CardExpiry CardExpiry { get; set; }
        public string HolderName { get; set; }
        public string CardType { get; set; }
        public string CardBin { get; set; }
        public string LastDigits { get; set; }
        public string CardCategory { get; set; }
    }
}
