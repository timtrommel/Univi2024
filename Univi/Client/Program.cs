using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Univi.Client;
using Univi.Client.Services.BuildingService;
using Univi.Client.Services.HandoverService;
using Univi.Client.Services.KeyService;
using Univi.Client.Services.KindofMalfunctionService;
using Univi.Client.Services.KindofReportService;
using Univi.Client.Services.MalfunctionService;
using Univi.Client.Services.ReportService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddHttpClient("Univi.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

//Add the new created services
builder.Services.AddScoped<IHandoverService,HandoverService>();
builder.Services.AddScoped<IReportService,ReportService>();
builder.Services.AddScoped<IKeyService, KeyService>();
builder.Services.AddScoped<IBuildingService, BuildingService>();
builder.Services.AddScoped<IKindofreportService, KindofreportService>();
builder.Services.AddScoped<IMalfunctionService,MalfunctionService>();
builder.Services.AddScoped<IKindofMalfunctionService, KindofMalfunctionService>();


// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Univi.ServerAPI"));

builder.Services.AddApiAuthorization();
builder.Services.AddBootstrapBlazor(); // Add this line

await builder.Build().RunAsync();
