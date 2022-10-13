using Products.Models;
using System.Net.Http.Json;

namespace Products.WASM
{
    public class ProductAPIService
    {
        private readonly HttpClient _httpClient;



        public ProductAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<Product>> SearchProducts(string productName, string productCode, string description)
        {
            if (!string.IsNullOrEmpty(productName))
            {
                productName = $"productName={productName}";
            }
            if (!string.IsNullOrEmpty(description))
            {
                description = $"description={description}";
            }
            if (!string.IsNullOrEmpty(productCode))
            {
                productCode = $"productCode={productCode}";
            }
            var query = $"{productName}&{description}&{productCode}";

            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>($"{APIEndPoints.ServerBaseUrl}{APIEndPoints.products}?{query}");

            return result;
        }

        public async Task<bool> AddProduct(Product product)
        {
            var result = await _httpClient.PostAsJsonAsync($"{APIEndPoints.ServerBaseUrl}{APIEndPoints.products}", product);
            return result.IsSuccessStatusCode;

        }
    }
}
