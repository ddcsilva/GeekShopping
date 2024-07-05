using GeekShopping.ProdutoAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionMySQL = builder.Configuration.GetConnectionString("MySQLConnection:MySQLConnectionString");
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connectionMySQL, ServerVersion.AutoDetect(connectionMySQL)));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
