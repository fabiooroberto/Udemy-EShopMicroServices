var builder = WebApplication.CreateBuilder(args);
// Add services to the contaners.

//---------------
//Infrastructure - EF Core
//Application - MediatR
//Api - Carter, HealthChecks, ...

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();
//---------------
var app = builder.Build();

app.UseApiServices();

app.Run();
