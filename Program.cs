using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorApp;
using MudBlazor.Services;
using BlazorApp.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();
builder.Services.AddScoped<FirebaseAuthService>();
builder.Services.AddScoped<AuthenticationStateProvider, FirebaseAuthStateProvider>();
builder.Services.AddScoped<FirebaseAuthStateProvider>();
builder.Services.AddScoped<FirestoreCacheService>();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
