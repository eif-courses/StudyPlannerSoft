using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints().SwaggerDocument();

builder.Services.AddDbContext<MyDatabaseContext>(options =>
{
    options.UseSqlite("Data Source=MyDatabase.db");
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});


var app = builder.Build();

//app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");

app.UseFastEndpoints().UseSwaggerGen();

app.Run();
