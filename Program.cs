using apihookup.helpers;
using apihookup.interfaces;
using apihookup.repository;
using apihookup.service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//add scoped services
builder.Services.AddScoped<IAuthService, authService>();

//!!change to AuthRepo when ready to use real database!!
builder.Services.AddScoped<IAuthRepo, MockRepo>();


//add appsettings to the configuration
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
