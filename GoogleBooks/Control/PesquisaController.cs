using System.Configuration;
using System.Threading.Tasks;
using GoogleBooks.Model;
using GoogleBooks.Connection;
using System.Text.Json;
using System.Net;

namespace GoogleBooks.Control
{
    class PesquisaController : HttpManager
    {
        private Book books { get; set; }
        private string keyApi;
        private string endPointApi;
        private int maxResults;
        public PesquisaController() 
        {
            keyApi = ConfigurationManager.AppSettings.Get("KEY_API");
            endPointApi = ConfigurationManager.AppSettings.Get("ENDPOINT_API");
            maxResults = int.Parse(ConfigurationManager.AppSettings.Get("MAX_RESULTS"));
        }

        public async Task<ItemsBook> getBooks(string searchContent, int startIndex = 0, int maxResults = 0)
        {
            ItemsBook books = new ItemsBook();
            string result = "";
            if (maxResults == 0)
            {
                maxResults = this.maxResults;
            }
            if (!string.IsNullOrEmpty(searchContent))
            {
                string[] words = searchContent.Split(' ');
                searchContent = string.Join("+", words);
            }
            startIndex = (startIndex) * maxResults;
            string url = $"{endPointApi}?key={keyApi}{(!string.IsNullOrEmpty(searchContent) ? $"&q={WebUtility.UrlEncode(searchContent)}" : "")}&maxResults={maxResults}&startIndex={startIndex}";
            result = await getResult(url);
            books = JsonSerializer.Deserialize<ItemsBook>(result);
            return books;
        } 
    }
}
