using app.web.Dtos.Products;

namespace app.web.Pages.Http.Products
{
    public interface IProductSlice
    {
        Task<List<ProductDto>?> GetAllProducts();
    }
}
