var builder = WebApplication.CreateBuilder(args);
// Add services to the contaners.

//---------------
//Infrastructure - EF Core
//Application - MediatR
//Api - Carter, HealthChecks, ...

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices(builder.Configuration);
//---------------
var app = builder.Build();

app.UseApiServices();

if(app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}

app.Run();
