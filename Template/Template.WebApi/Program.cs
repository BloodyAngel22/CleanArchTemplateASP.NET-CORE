using Template.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddRepositories().AddServices().AddValidators();

builder.Services.AddPostgres();

// UNCOMMENT TO USE MONGODB
// builder.Services.AddMongo();

builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionMiddleware();

app.UseDatabaseMigration();

app.UseScalar(app.Environment);
app.UseHttpsRedirection();

app.ConfigureRouting();

app.Run();
