
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureServices();
builder.Services.AddCors();
var app = builder.Build();
string[] allowedOrigins = builder.Configuration
    .GetSection("AllowedOrigins")
    .GetSection(app.Environment.EnvironmentName)
    .Get<string[]>() ?? Array.Empty<string>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy
    .WithOrigins(allowedOrigins)
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
