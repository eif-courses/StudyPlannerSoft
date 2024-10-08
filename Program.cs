using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Features.Groups;
using StudyPlannerSoft.Features.Lecturers;
using StudyPlannerSoft.Features.Subjects;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var isDevelopment = builder.Environment.IsDevelopment();

var npgsqlConnectionString = new NpgsqlConnectionStringBuilder
{
    Host = Environment.GetEnvironmentVariable("POSTGRES_HOST"),
    Port = Convert.ToInt32(Environment.GetEnvironmentVariable("POSTGRES_PORT")),
    Username = Environment.GetEnvironmentVariable("POSTGRES_USER"),
    Password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD"),
    Database = Environment.GetEnvironmentVariable("POSTGRES_DB"),
    SslMode = isDevelopment ? SslMode.Disable : SslMode.Require // DISABLE FOR LOCAL
};

builder.Services.AddDbContext<MyDatabaseContext>(options =>
{
    options.UseNpgsql(npgsqlConnectionString.ConnectionString);
});


builder.Services.AddIdentity<MyUser, IdentityRole>()
    .AddEntityFrameworkStores<MyDatabaseContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAuthenticationCookie(validFor: TimeSpan.FromDays(30), options =>
{
    options.Cookie.Name = "authToken";
    options.LoginPath = "/auth/login";
    options.LogoutPath = "/auth/logout";
    options.SlidingExpiration = true;
    options.Cookie.SameSite = SameSiteMode.None; // Allow cross-origin requests
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Set to None for local development
    options.Cookie.Path = "/";
});


builder.Services.AddScoped<ImportSubjectsService>();
builder.Services.AddScoped<ImportLecturersService>();
builder.Services.AddScoped<ImportGroupsService>();


builder.Services.AddAuthorization();
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
        policy.WithOrigins("http://localhost:3000", "http://localhost:63342")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});

var app = builder.Build();


app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");
app.UseAuthentication();
app.UseAuthorization();
app.UseFastEndpoints();

app.UseSwaggerGen();

app.Run();