using DependencyInjection1;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services
    .AddConfig(builder.Configuration)
    .AddMyDependencyGroup();


var app = builder.Build();

app.MapRazorPages();

app.Run();