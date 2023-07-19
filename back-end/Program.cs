using Ecomerce.Repositories;
using Ecomerce.Data;
using Microsoft.OpenApi.Models;
using Ecomerce.Services;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using DotNetEnv;
using System.Text.Json.Serialization;
using Serilog;


Env.Load();
var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
var builder = WebApplication.CreateBuilder(args);


Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductsRepository>();
builder.Services.AddScoped<AuthInterface, AuthService>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAuthentication(a =>
{
  a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(j =>
{
  j.RequireHttpsMetadata = false;
  j.SaveToken = true;
  j.TokenValidationParameters = new TokenValidationParameters
  {
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(key),
    ValidateIssuer = false,
    ValidateAudience = false,
    ClockSkew = TimeSpan.Zero
  };
});
builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ecomerce", Version = "v1" });
});
builder.Services.AddLogging(loggingBuilder =>
{
  loggingBuilder.AddSerilog(dispose: true);
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage();
  app.UseSwagger();
  app.UseSwaggerUI(c =>
  {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecomerce V1");
  });
}


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
