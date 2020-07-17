using System.Net.Http;
using System.Threading.Tasks;

namespace GoogleBooks.Connection
{
    class HttpManager
    {
        protected static readonly HttpClient client = new HttpClient();
        protected static async Task<string> getResult(string url)
        {
            string responseBody = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                responseBody = "{\"error\": true, \"message\": \""+e.Message+"\"}";
            }
            return responseBody ?? "";
        }
    }
}
