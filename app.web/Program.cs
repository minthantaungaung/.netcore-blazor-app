using app.web;
using app.web.Pages.Http;
using app.web.Pages.Http.Products;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IHttpManager, HttpManager>();
//builder.Services.AddScoped<IProductSlice, ProductSlice>();
builder.Services.AddHttpClient();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["BaseAddressUrl"]!) });

await builder.Build().RunAsync();
