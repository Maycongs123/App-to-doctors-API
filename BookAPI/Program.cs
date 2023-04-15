using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//IServiceCollection serviceCollection = builder.Services.AddDbContext<BooksContext>(x => x.UseSqlServer("ConnectionStrings"));
builder.Services.AddDbContext<BooksContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionDataBase"));
});
builder.Services.AddScoped<IBookRepository, BookRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
