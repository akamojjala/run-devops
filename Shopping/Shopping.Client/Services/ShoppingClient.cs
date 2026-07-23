using Newtonsoft.Json;
using Shopping.Client.Models;

namespace Shopping.Client.Services
{
    public class ShoppingClient : IShoppingClient
    {
        private readonly HttpClient _httpClient;
        public ShoppingClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ShoppingAPIClient");
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync("/product");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
        }
    }
}
