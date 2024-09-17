using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDatabaseContext>(options => { options.UseSqlite("Data Source=MyDatabase.db"); });

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<MyDatabaseContext>();

builder.Services
    .AddAuthenticationCookie(validFor: TimeSpan.FromMinutes(60))
    .AddAuthorization()
    .AddFastEndpoints()
    .SwaggerDocument();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});

var app = builder.Build();

app.UseAuthentication()
    .UseAuthorization()
    .UseFastEndpoints()
    .UseSwaggerGen();

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.Run();