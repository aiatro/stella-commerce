using System;
using System.Collections.Generic;

namespace Stella_Commerce.web.resource
{
    public class PaymentHandle
    {
        public string Id { get; set; }
        public string PaymentType { get; set; }
        public string PaymentHandleToken { get; set; }
        public string MerchantRefNum { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime TxnTime { get; set; }
        public BillingDetails BillingDetails { get; set; }
        public string CustomerIp { get; set; }
        public string Status { get; set; }
        public bool LiveMode { get; set; }
        public string Usage { get; set; }
        public string Action { get; set; }
        public string ExecutionMode { get; set; }
        public int Amount { get; set; }
        public MerchantDescriptor MerchantDescriptor { get; set; }
        public int TimeToLiveSeconds { get; set; }
        public GatewayResponse GatewayResponse { get; set; }
        public List<Link> ReturnLinks { get; set; }
        public string TransactionType { get; set; }
        public Guid GatewayReconciliationId { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime StatusTime { get; set; }
        public Skrill Skrill { get; set; }
        public Profile Profile { get; set; }
    }

}
