using GrpcService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

app.UseRouting();

// Configure the HTTP request pipeline.
app.MapGrpcService<WeatherService>();

app.Run();