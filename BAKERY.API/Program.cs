using BAKERY.Application.Contracts;
using BAKERY.Application.Services;
using BAKERY.Domain.Repositories;
using BAKERY.Infrastructure.EntityFramework.Contexts;
using BAKERY.Infrastucture.EntityFramework.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
IServiceCollection serviceCollection = builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataBaseContext>();
builder.Services.AddScoped<IBunRepository, BunRepository>();
builder.Services.AddScoped<IBunService, BunService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );

app.UseAuthorization();

app.MapControllers();

app.Run();
