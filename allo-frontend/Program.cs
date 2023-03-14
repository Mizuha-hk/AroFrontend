using allo_frontend;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored;
using Blazored.Modal;
using Blazored.Modal.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://app-backend-debug.azurewebsites.net/api/") });
builder.Services.AddScoped<Services>();
builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();
