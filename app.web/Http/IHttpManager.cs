using app.web.Pages.Http.Products;

namespace app.web.Pages.Http
{
    public interface IHttpManager
    {
        public IProductSlice products { get; }
    }
}
