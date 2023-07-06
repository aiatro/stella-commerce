using System;

namespace Stella_Commerce.web.resource
{
    public class CardPayment
    {
        public string Id { get; set; }
        public string PaymentType { get; set; }
        public string PaymentHandleToken { get; set; }
        public string MerchantRefNum { get; set; }
        public string CurrencyCode { get; set; }
        public bool SettleWithAuth { get; set; }
        public DateTime TxnTime { get; set; }
        public BillingDetails BillingDetails { get; set; }
        public string CustomerIp { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
        public bool PreAuth { get; set; }
        public string Description { get; set; }
        public int AvailableToSettle { get; set; }
        public GatewayResponse GatewayResponse{get;set;}
        public MerchantDescriptor MerchantDescriptor{get;set;}
        public Card Card{get; set;} 
}
}
