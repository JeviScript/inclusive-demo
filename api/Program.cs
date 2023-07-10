using api;
using api.Repositories;
using api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// env variables
Env.Configure(builder.Services, builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// setup dbContext
builder.Services.AddDbContext<PlanetsDb>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetSection("DbSettings").GetValue<string>("ConnectionString")
        )
);

// setup DI
Repositories.Configure(builder.Services);
Services.Configure(builder.Services);

var allowUrl = builder.Configuration.GetValue<string>("AllowUrl");

Console.WriteLine($"Allow url: {allowUrl}");

var app = builder.Build();

if (allowUrl != null)
{
    app.UseCors(
        builder =>
            builder
                .WithOrigins(new string[] { allowUrl })
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
    );
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
