using app.web.Dtos;
using app.web.Dtos.Products;
using Newtonsoft.Json;

namespace app.web.Pages.Http.Products
{
    public class ProductSlice : IProductSlice
    {
        private HttpClient _client;

        public ProductSlice(HttpClient httpClient)
        {
            _client = httpClient;
        }
        public async Task<List<ProductDto>?> GetAllProducts()
        {
            try
            {
                var APIResponse = await _client.GetAsync("2e4436ae-f1e1-452a-8eec-f4ecada870b5");
                //var APIResponse = await _client.GetAsync("products");

                if (APIResponse.IsSuccessStatusCode)
                {
                    var content = await APIResponse.Content.ReadAsStringAsync();
                    var formattedResponse = JsonConvert.DeserializeObject<BaseRespModel<List<ProductDto>>>(content);
                    List<ProductDto>? response = formattedResponse?.Data?.ToList();
                    return response;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
