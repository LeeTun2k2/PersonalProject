using Serilog;
using Serilog.Extensions.Logging;
using UserService.Application;
using UserService.Core;
using UserService.Core.Models.EmailModels;
using UserService.Core.Models.TokenModels;
using UserService.Identity;
using UserService.Infrastructure;

var logger = Log.Logger = new LoggerConfiguration()
  .Enrich.FromLogContext()
  .WriteTo.Console()
  .CreateLogger();

logger.Information("Starting web host");

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));
var microsoftLogger = new SerilogLoggerFactory(logger).CreateLogger<Program>();

// Configure Web Behavior
builder.Services.Configure<CookiePolicyOptions>(options =>
{
  options.CheckConsentNeeded = context => true;
  options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.Configure<MailSettingsModel>(builder.Configuration.GetSection("MailSettings"));
builder.Services.Configure<JwtSettingsModel>(builder.Configuration.GetSection("Jwt"));

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddIdentityExtensions(builder.Configuration);
builder.Services.AddCoreServices();
builder.Services.AddApplicationServices();

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
  app.UseDeveloperExceptionPage();
}
else
{
  app.UseHsts();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
