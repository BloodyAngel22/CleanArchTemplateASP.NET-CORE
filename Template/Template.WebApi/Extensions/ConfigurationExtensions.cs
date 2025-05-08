namespace Template.WebApi.Extensions;

public static class ConfigurationExtensions
{
    public static string GetSectionValueOrThrow(this IConfiguration configuration, string sectionName)
    {
        var section = configuration.GetSection(sectionName) ?? throw new Exception($"Missing configuration section: {sectionName}");

        return section.Value ?? throw new Exception($"Missing configuration value: {sectionName}");
    }

    public static string GetConnectionStringOrThrow(this IConfiguration configuration, string connectionStringName)
    {
        var connectionString = configuration.GetConnectionString(connectionStringName) ?? throw new Exception($"Missing connection string: {connectionStringName}");

        return connectionString;
    }
}