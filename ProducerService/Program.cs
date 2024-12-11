using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

// Add Steeltoe Discovery Client
builder.Services.AddDiscoveryClient(builder.Configuration);

builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.UseDiscoveryClient();

app.MapControllers();

app.Run();
