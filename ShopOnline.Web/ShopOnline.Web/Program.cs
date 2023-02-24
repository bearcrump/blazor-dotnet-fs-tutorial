using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// the line below is DI  configuration for the HttpClient used by blazor FE. Uri argument was replaced with base URL in use by API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7191/") });

await builder.Build().RunAsync();
