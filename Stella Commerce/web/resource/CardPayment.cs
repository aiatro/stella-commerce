using System;

namespace Stella_Commerce.web.resource
{
    public class CardPayment
    {
        private string Id { get; set; }
        private string PaymentType { get; set; }
        private string PaymentHandleToken { get; set; }
        private string MerchantRefNum { get; set; }
        private string CurrencyCode { get; set; }
        private bool SettleWithAuth { get; set; }
        private DateTime TxnTime { get; set; }
        private BillingDetails BillingDetails { get; set; }
        private string CustomerIp { get; set; }
        private string Status { get; set; }
        private int Amount { get; set; }
        private bool PreAuth { get; set; }
        private string Description { get; set; }
        private int AvailableToSettle { get; set; }
        private GatewayResponse GatewayResponse{get;set;}
        private MerchantDescriptor MerchantDescriptor{get;set;}
        private Card Card{get; set;} 
    }
}
