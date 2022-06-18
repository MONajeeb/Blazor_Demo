using Lab3_sol;
using Lab3_sol.Models;
using Lab3_sol.ServiceWebApi;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddScoped<Iservice<Category>,CategoryService>(); 
//builder.Services.AddScoped<Iservice<Product>, ProductService>();
//builder.Services.AddScoped(sp => 

//    new HttpClient
//{
//    BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["ApiUrl"])

//});

builder.Services.AddHttpClient<Iservice<Product>, ProductService>(
               (sp, httpclient) => {
                   httpclient.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["ApiUrl"]);
               }
               );
builder.Services.AddHttpClient<Iservice<Category>, CategoryService>(
    (sp, httpclient) => {
        httpclient.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["ApiUrl"]);
    }
    );

await builder.Build().RunAsync();
