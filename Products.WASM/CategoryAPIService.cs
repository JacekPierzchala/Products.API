using Products.Models;
using System.Net.Http.Json;

namespace Products.WASM
{
    public class CategoryAPIService
    {
        private readonly HttpClient _httpClient;

        public IEnumerable<Category> Categories { get; set; }
        public CategoryAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            if(Categories==null)
            {
                var result = await _httpClient.GetFromJsonAsync<IEnumerable<Category>>($"{APIEndPoints.ServerBaseUrl}{APIEndPoints.category}");

                Categories= result;
            }
            return Categories;
        }

    
    }
}
