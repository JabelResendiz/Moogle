
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MoogleServer.Services;

//namespace MoogleEngine;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<SearchService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

MoogleEngine.Principal s = new MoogleEngine.Principal();

app.Run();//abrir la pagina web 


