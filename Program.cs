using apihookup.helpers;
using apihookup.interfaces;
using apihookup.Models;
using apihookup.repository;
using apihookup.service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//add scoped services
builder.Services.AddScoped<IAuthService, authService>();
builder.Services.AddScoped<IAuthRepo, AuthRepo>();
builder.Services.AddScoped<IHookupRepo, HookupRepo>();
builder.Services.AddScoped<ILogService, LogService>();
builder.Services.AddScoped<ILogRepo, LogRepo>();
builder.Services.AddDbContext<sqlContext>();

//add appsettings to the configuration
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
            s: builder.Configuration.GetValue<string>(key: "AppSettings:Secret")))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//cors configuration
app.UseCors(options =>
{
    options.SetIsOriginAllowed(x => true);
    options.AllowAnyMethod();
    options.AllowAnyHeader();
    options.AllowCredentials();
});

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();
