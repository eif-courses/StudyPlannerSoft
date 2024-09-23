using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using StudyPlannerSoft.Data;

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
    SslMode = SslMode.Require
};


builder.Services.AddDbContext<MyDatabaseContext>(options => { options.UseNpgsql(npgsqlConnectionString.ConnectionString); });


builder.Services.AddIdentity<MyUser, IdentityRole>()
    .AddEntityFrameworkStores<MyDatabaseContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAuthenticationCookie(validFor: TimeSpan.FromDays(30), options =>
{
    options.Cookie.Name = "authToken";
    options.LoginPath = "/api/auth/login";
    options.LogoutPath = "/api/auth/logout";
    options.Cookie.SameSite = SameSiteMode.None; //isDevelopment ? SameSiteMode.Lax : SameSiteMode.None;
    options.Cookie.SecurePolicy =
        CookieSecurePolicy.None; //isDevelopment ? CookieSecurePolicy.None : CookieSecurePolicy.Always;
});
builder.Services.AddAuthorization();
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<MyDatabaseContext>();
    context.Database.Migrate(); // Apply any pending migrations

    var userManager = services.GetRequiredService<UserManager<MyUser>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    // Seed users and roles
    await SeedData.Initialize(userManager, roleManager);
}


app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");
app.UseAuthentication();
app.UseAuthorization();
app.UseFastEndpoints();
app.UseSwaggerGen();

app.Run();