using Products.Models;

namespace Products.WASM
{
    public class FilterContainer
    {
        private readonly ProductAPIService _productAPIService;
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }

        public event Action? OnChange;
        public void NotifyStateChanged()=>OnChange?.Invoke();
        public IEnumerable<Product> Products { get; set; }
        //public IEnumerable<Product> ProductsFiltered { get; set; }

        public FilterContainer(ProductAPIService productAPIService)
        {
            _productAPIService = productAPIService;
        }
        public async Task LoadData()
        {    
                Products = await _productAPIService.SearchProducts(ProductName, ProductCode, Description);
                NotifyStateChanged();
        }
    }
}
