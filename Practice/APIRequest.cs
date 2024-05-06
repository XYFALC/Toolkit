using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Threading.Tasks;



namespace Practice
{
    public class APIRequest
    {
        public async Task<string> ApiCall(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string apiUrl = url;
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responsebody = await response.Content.ReadAsStringAsync();
                        return responsebody;
                    }
                    else
                    {
                        Console.WriteLine($"Failed to make request. Status code: {response.StatusCode}");
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return "";
                }
            }

        }


    }
}
