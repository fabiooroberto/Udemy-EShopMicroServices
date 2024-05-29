var builder = WebApplication.CreateBuilder(args);

// Add Services to container (DI)

var app = builder.Build();

// Configure the HTTP request pipeline

app.Run();
