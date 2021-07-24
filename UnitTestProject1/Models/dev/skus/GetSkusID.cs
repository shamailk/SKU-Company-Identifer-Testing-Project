using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;


/*This the Class created for the Get{id} Endpoint */
namespace API
{
        public class GetSkusID
        {
                private static RestClient RestClient { get; set; }
                private static IRestResponse Reponse { get; set; }
                private static RestRequest RestRequest { get; set; }
                private void InitialiseEndpoint()
                {
                        RestClient = new RestClient();

                     

                        RestRequest = new RestRequest("dev/skus/{id}", Method.GET);
                     
                          
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
                        Assert.AreEqual(System.Net.HttpStatusCode.OK, Reponse.StatusCode, "This should return a 200 reponse after deleting a SKU entry");
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