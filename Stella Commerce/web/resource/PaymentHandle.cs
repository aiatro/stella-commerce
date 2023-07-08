using System.Collections.Generic;

namespace Stella_Commerce.web.resource
{
    public class PaymentHandle
    {
        public PaymentHandle() { }
        private string MerchantRefNum { get; set; }
        private string PaymentHandleToken { get; set; }
        private string TransactionType { get; set; }
        private string AccountId { get; set; }
        private string PaymentType { get; set; }
        private int Amount { get; set; }
        private string CurrencyCode { get; set; }
        private Profile Profile { get; set; }
        private BillingDetails BillingDetails { get; set; }
        private MerchantDescriptor MerchantDescriptor { get; set; }
        private List<Link> ReturnLinks { get; set; }
        private Card Card { get; set; }

    }

}
