using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ConnectPOC.Blazor;
using ConnectPOC.Blazor.Services;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Load appsettings.json from wwwroot
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Register UserService
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var baseUrl = configuration["ApiSettings:BaseUrl"];
    return new HttpClient { BaseAddress = new Uri(baseUrl) };
});


builder.Services.AddMudServices();
builder.Services.AddScoped<GlobalStateService>();

await builder.Build().RunAsync();
