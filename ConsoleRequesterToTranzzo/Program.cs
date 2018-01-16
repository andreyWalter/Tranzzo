using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace ConsoleRequesterToTranzzo
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine($"Response\r\n" + RequestSender());
           Console.ReadLine();
        }

        public static string RequestSender()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls |
                                       SecurityProtocolType.Tls11 |
                                       SecurityProtocolType.Tls12|
                                        SecurityProtocolType.Ssl3;
            
            const string API_KEY = "a53bec42-e806-49ec-b2ab-1bb86eb441d1";
            const string API_SECRET = "SXNHcFhMdG83Qnk5NnRwbGxLbklQdnlP";

            const string BaseUrl = "https://cpay.tranzzo.com/api/v1";
            const string BaseUrlKey = "AIzaSyAUp_YrSRiInJgiIbBINIP1iC7IpDVl_q8";

            string url = $"{BaseUrl}/payment?key={BaseUrlKey}";

            var client = new RestClient(url);

            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("X-API-Auth", $"CPAY {API_KEY}:{API_SECRET}");
            request.AddHeader("x-api-key", BaseUrlKey);

            string json = @"{
            ""pos_id"": ""c542ba36-6ba3-4aca-907f-71dda949ccf9"",
            ""mode"": ""direct"",
            ""method"": ""purchase"",
            ""amount"": 1,
            ""cc_number"": ""4731185604448784"",
            ""exp_month"": 4,
            ""exp_year"": 25,
            ""card_cvv"": ""922"",
            ""currency"": ""UAH"",
            ""description"": ""description text"",
            ""order_id"": ""order_belial12"",
            ""products"": [
                {
                ""id"": ""2"",
                ""name"": ""Product 2"",
                ""url"": ""http://www.test.com/product2"",
                ""category"": ""category_2"",
                ""description"": ""Super product 2"",
                ""currency"": ""USD"",
                ""amount"": 15.5,
                ""price_type"": ""gross"",
                ""vat"": 2.5,
                ""qty"": 20,
                ""payload"": ""THIS_IS PRODUCT_2_PAYLOAD""
                }
            ],
            ""order_3ds_bypass"": ""supported"",
            ""customer_id"": ""123456"",
            ""customer_email"": ""email@email.com"",
            ""customer_fname"": ""John"",
            ""customer_lname"": ""Doe"",
            ""customer_phone"": ""202-318-0835"",
            ""customer_pc_fingerprint"": ""SSKjsfSFJIIEWFWIFjmvmdDFKKEJWIfw93fJFJ"",
            ""customer_User_agent"": ""Firefox 5.0"",
            ""server_url"": ""http://www.interkassa.com/iam"",
            ""result_url"": ""http://www.interkassa.com/result""
            }";

            var jsonObj = JsonConvert.DeserializeObject(json);

            /*Для debug, проверки структуры */
            var requestToTranzzo = JsonConvert.SerializeObject(jsonObj);

            request.AddJsonBody(jsonObj);
            
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            
            return content;
        }
    }
}
