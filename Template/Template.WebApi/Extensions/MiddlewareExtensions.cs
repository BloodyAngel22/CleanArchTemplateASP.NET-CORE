namespace Template.WebApi.Extensions
{
    public static class MiddlewareExtensions
    {
		public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			return app;
		}

		public static IApplicationBuilder ConfigureMiddleware(this IApplicationBuilder app)
		{
			app.UseHttpsRedirection();

			return app;
		}

		public static void ConfigureRouting(this WebApplication app)
		{
			app.MapControllers();
		}
    }
}