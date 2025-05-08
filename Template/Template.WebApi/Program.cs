using Template.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.
    AddRepositories().
    AddServices().
    AddValidators();

builder.Services.AddPostgres(builder.Configuration.GetConnectionStringOrThrow("Postgres"));

// UNCOMMENT TO USE MONGODB
// builder.Services.AddMongo(builder.Configuration.GetSectionValueOrThrow("MongoDBSettings:ConnectionString"), builder.Configuration.GetSectionValueOrThrow("MongoDBSettings:DatabaseName"));

builder.Services.AddControllers();

var app = builder.Build();

app.UseExceptionMiddleware();

app.UseScalar(app.Environment);
app.UseHttpsRedirection();

app.ConfigureRouting();

app.Run();