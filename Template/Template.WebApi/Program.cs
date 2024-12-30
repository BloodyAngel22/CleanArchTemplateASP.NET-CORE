using Template.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddSwaggerDocumentation();
builder.Services.AddControllers();

var app = builder.Build();

app.UseSwaggerDocumentation(app.Environment);
app.ConfigureMiddleware();
app.ConfigureRouting();

app.Run();