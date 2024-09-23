using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Data;

var builder = WebApplication.CreateBuilder(args);

var isDevelopment = builder.Environment.IsDevelopment();



if (isDevelopment)
{
    builder.Services.AddDbContext<MyDatabaseContext>(options => { options.UseSqlite("Data Source=MyDatabase.db"); });
}

else
{
    var connectionString = Environment.GetEnvironmentVariable("DATABASE_PUBLIC_URL");

    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("DATABASE_PUBLIC_URL environment variable is not set.");
    }

    // Modify the connection string to work with Npgsql
    connectionString = connectionString.Replace("postgres://", "Host=")
        .Replace(":", ";Port=")
        .Replace("@", ";Username=")
        .Replace("/", ";Database=");

    // Append SSL and certificate settings if necessary
    connectionString += ";SSL Mode=Require;Trust Server Certificate=true;";

    // Configure the DbContext to use PostgreSQL
    builder.Services.AddDbContext<MyDatabaseContext>(options =>
    {
        options.UseNpgsql(connectionString);
    });
}

builder.Services.AddIdentity<MyUser, IdentityRole>()
    .AddEntityFrameworkStores<MyDatabaseContext>()
    .AddDefaultTokenProviders();





builder.Services.AddAuthenticationCookie(validFor: TimeSpan.FromMinutes(2), options =>
{
    options.Cookie.Name = "authToken";
    options.LoginPath = "/api/auth/login";
    options.LogoutPath = "/api/auth/logout";
    options.Cookie.SameSite = isDevelopment ? SameSiteMode.Lax : SameSiteMode.None;
    options.Cookie.SecurePolicy = isDevelopment ? CookieSecurePolicy.None : CookieSecurePolicy.Always;
    
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