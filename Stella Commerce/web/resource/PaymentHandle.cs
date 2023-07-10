using System.Collections.Generic;

namespace Stella_Commerce.web.resource
{
    public class PaymentHandle
    {
        public PaymentHandle() { }
        public string MerchantRefNum { get; set; }
        public string PaymentHandleToken { get; set; }
        public string TransactionType { get; set; }
        public string AccountId { get; set; }
        public string PaymentType { get; set; }
        public int Amount { get; set; }
        public string CurrencyCode { get; set; }
        public Profile Profile { get; set; }
        public BillingDetails BillingDetails { get; set; }
        public MerchantDescriptor MerchantDescriptor { get; set; }
        public List<Link> ReturnLinks { get; set; }
        public Card Card { get; set; }

    }

}
