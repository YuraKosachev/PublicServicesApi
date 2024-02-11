using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using PublicServicesApi.Code.Middleware;
using PublicServicesApi.Core.Interfaces.Providers;
using PublicServicesApi.Core.Interfaces.Services;
using PublicServicesApi.Core.Models.Configuration;
using PublicServicesApi.Provider.ApiProviders;
using PublicServicesApi.Service.Services;
using System.Net;
using System.Reflection;

ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Tls13;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfigurationRoot config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

// Get values from the config given their key and their target type.

builder.Services.Configure<ApiServicesConfiguration>(options => config.GetSection("ApiServices").Bind(options));
builder.Services.AddTransient<IPublicServicesService, PublicServicesService>();
builder.Services.AddTransient<IApiServicesProvider, ApiServicesProvider>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    option =>
    {
        option.SwaggerDoc("v1",
            new OpenApiInfo
            {
                Title = "Public services Api",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "Yury Kosachou",
                    Email = "zanoza.by@gmail.com"
                }
            });
        option.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, Assembly.GetExecutingAssembly().GetName().Name + ".xml"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware(typeof(ErrorHandlingMiddleware));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
