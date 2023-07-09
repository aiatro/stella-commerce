using Stella_Commerce.web.resource;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Stella_Commerce.web.client
{
    public class PaymentClient
    {
        private readonly string ApiKey = System.Environment.GetEnvironmentVariable("payments_api_key");
        private readonly string Password = System.Environment.GetEnvironmentVariable("payments_api_key_pass");
        private readonly string ApiBaseRoute = "https://api.test.paysafe.com/paymenthub";
        private readonly static HttpClient Client = new();

        private PaymentClient()
        {
            Client.BaseAddress = new System.Uri(ApiBaseRoute);
            byte[] authorizationHeaderBytes = Encoding.UTF8.GetBytes($"{ApiKey}:{Password}");
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", System.Convert.ToBase64String(authorizationHeaderBytes));

        }

        public PaymentHandle CreatePaymentHandle(PaymentHandle paymentHandle)
        {
            return null;
        }
/*        public void 
*/        
    }
}
