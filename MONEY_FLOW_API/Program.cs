using MONEY_FLOW_API.Repository;
using MONEY_FLOW_API.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Load configuration
var configuration = builder.Configuration;
var clientUrl = configuration.GetValue<string>("ApplicationSettings:Client_URL");

// Read JWT settings from config
var jwtSettings = configuration.GetSection("JWT");

// Make sure Secret is present (avoid ArgumentNullException)
var secret = jwtSettings["Secret"];
if (string.IsNullOrWhiteSpace(secret))
{
    throw new InvalidOperationException("JWT:Secret is not configured in appsettings.json");
};

// Convert secret string to bytes
var keyBytes = Encoding.UTF8.GetBytes(secret);
var signingKey = new SymmetricSecurityKey(keyBytes);

// ==- Add services to the container -== //
ConfigureServices(builder.Services);

void ConfigureServices(IServiceCollection services)
{
    // Configure CORS
    ConfigureCors(services, clientUrl);

    services.AddControllers();              // Add Controller
    RegisterApplicationServices(services);  // Add Repository and Services
}

void ConfigureCors(IServiceCollection services, string clientUrl)
{
    services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins(clientUrl)
                   .AllowAnyHeader()
                   .AllowAnyMethod();
                 //.AllowCredentials();
        });
    });
}

void RegisterApplicationServices(IServiceCollection services)
{
    services.AddServices();
    services.AddRepository();
}

// ==- Add authentication -== //
builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false; // true in production with HTTPS
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = signingKey
        };
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors();

app.UseHttpsRedirection();

// Note: order is important !!
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
