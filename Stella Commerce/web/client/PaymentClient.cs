using Stella_Commerce.web.resource;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Stella_Commerce.web.client
{
    public class PaymentClient
    {
        private readonly string ApiKey = System.Environment.GetEnvironmentVariable("payments_api_key");
        private readonly string Password = System.Environment.GetEnvironmentVariable("payments_api_key_pass");
        private readonly string ApiBaseRoute = "https://api.test.paysafe.com/";
        private readonly static HttpClient Client = new();

        public PaymentClient()
        {
            Client.BaseAddress = new System.Uri(ApiBaseRoute);
            byte[] authorizationHeaderBytes = Encoding.UTF8.GetBytes($"{ApiKey}:{Password}");
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", System.Convert.ToBase64String(authorizationHeaderBytes));
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public PaymentHandle CreatePaymentHandle(PaymentHandle paymentHandle)
        {
            JsonSerializerOptions options = new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };

            HttpRequestMessage request = new(HttpMethod.Post, "paymenthub/v1/paymenthandles")
            {

                Content = new StringContent(JsonSerializer.Serialize(paymentHandle, options), Encoding.UTF8, "application/json")
            };

            HttpResponseMessage response = Client.Send(request);
            using StreamReader reader = new StreamReader(response.Content.ReadAsStream());
            string responseBody = reader.ReadToEnd();
            Console.WriteLine(responseBody);
            
            return JsonSerializer.Deserialize<PaymentHandle>(responseBody, options);

        }
/*        public void 
*/        
    }
}
