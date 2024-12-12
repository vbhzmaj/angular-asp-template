using bckndtmp;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddMvc();
builder.Services.AddDbContext<QuizContext>(options =>
                                            options.UseInMemoryDatabase("quiz"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});


app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
