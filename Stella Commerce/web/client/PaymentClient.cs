using Stella_Commerce.web.resource;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Stella_Commerce.web.client
{
    public class PaymentClient
    {
        private readonly string ApiKey = System.Environment.GetEnvironmentVariable("payments_api_key");
        private readonly string Password = System.Environment.GetEnvironmentVariable("payments_api_key_pass");
        private readonly string ApiBaseRoute = "https://api.test.paysafe.com/paymenthub/v1";
        private readonly static HttpClient Client = new();

        private PaymentClient()
        {
            Client.BaseAddress = new System.Uri(ApiBaseRoute);
            byte[] authorizationHeaderBytes = Encoding.UTF8.GetBytes($"{ApiKey}:{Password}");
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", System.Convert.ToBase64String(authorizationHeaderBytes));

        }

        public async Task<PaymentHandle> CreatePaymentHandle(PaymentHandle paymentHandle)
        {
            using HttpResponseMessage response = await Client.PostAsJsonAsync("/paymenthandles", paymentHandle);
            PaymentHandle body = await response.Content.ReadFromJsonAsync<PaymentHandle>();
            return null;
        }
/*        public void 
*/        
    }
}
