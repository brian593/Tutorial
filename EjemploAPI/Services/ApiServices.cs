using System;
using System.Diagnostics;
using System.Net;
using EjemploAPI.Models;
using Newtonsoft.Json;

namespace EjemploAPI.Services;

public class ApiServices : IApiServices
{
    public async Task<Country> GetCountryInfo()
    {
        try
            {
                string  endpoint = "https://api-colombia.com/api/v1/Country/Colombia";
                var httpClient = new HttpClient();
                var httpMethod = HttpMethod.Get;

                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(endpoint),
                    Method = httpMethod
                };
                //request.Headers.Add("Authorization", Token);

                var httpResponse = await httpClient.SendAsync(request);
                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Country>(result);
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"No fue posible conectarse {ex.Message}");
                return null;
            }
    }
}
