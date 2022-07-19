using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    // Microsoft.Identity.Webを使う
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddAuthorization();

builder.Services.AddRazorPages()
    // Microsoft.Identity.Web.UIを使う
    .AddMicrosoftIdentityUI();   

var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
