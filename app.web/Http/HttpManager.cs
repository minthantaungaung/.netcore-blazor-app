using app.web.Pages.Http.Products;
using System.Net;

namespace app.web.Pages.Http
{
    public class HttpManager : IHttpManager
    {
        private readonly Lazy<IProductSlice> _productSlice;

        public HttpManager(HttpClient httpClient)
        {
            _productSlice = new Lazy<IProductSlice>(() => new ProductSlice(httpClient));

        }
        public IProductSlice products => _productSlice.Value;
    }
}
