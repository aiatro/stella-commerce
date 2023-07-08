using Stella_Commerce.web.resource;

namespace Stella_Commerce.web.client
{
    public class PaymentClient
    {
        private readonly string apiKey = System.Environment.GetEnvironmentVariable("payments_api_key");
        private readonly string password = System.Environment.GetEnvironmentVariable("payments_api_key_pass");
        private readonly string apiBaseRoute = "https://api.test.paysafe.com/paymenthub";

        public PaymentHandle CreatePaymentHandle(PaymentHandle paymentHandle)
        {
            return null;
        }
/*        public void 
*/        
    }
}
