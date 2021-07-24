using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;


/*This the Class created for the POST Endpoint */
namespace API
{
        public class PostSkus
        {
                private static RestClient RestClient { get; set; }
                private static IRestResponse Reponse { get; set; }
                private static RestRequest RestRequest { get; set; }
                private void InitialiseEndpoint()
                {
                        RestClient = new RestClient();
                        
                        JObject jObjectbody = new JObject();
                        jObjectbody.Add("sku", "123456");
                        jObjectbody.Add("description", "Shamail Testing");
                        jObjectbody.Add("price", "1.25");

                        RestRequest = new RestRequest("dev/skus/", Method.POST);
                        RestRequest.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
                }
                
                private void AddEndpoint()
                {
                        var endpointUri = new Uri("https://1ryu4whyek.execute-api.us-west-2.amazonaws.com/");
                        RestClient.BaseUrl = endpointUri;
                }
                private void SendGetInfoRequest()
                {
                        Reponse = RestClient.Execute(RestRequest);
                        Console.WriteLine(JsonConvert.SerializeObject(Reponse.Content, Formatting.Indented));
                }
                private void ValidateResponse()
                {
                        Assert.AreEqual(System.Net.HttpStatusCode.OK, Reponse.StatusCode, "The POST was done succesfully");
                       
                }
                public void SendRequestAndValidateResponse()
                {
                        InitialiseEndpoint();
                        AddEndpoint();
                        SendGetInfoRequest();
                        ValidateResponse();
                }
        }
}