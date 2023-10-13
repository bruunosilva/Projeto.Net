using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Projeto01.Infra.Data.SqlServer.Contexts;

public class SqlServerFactory : IDesignTimeDbContextFactory<SqlServerContext>
{
    public SqlServerContext CreateDbContext(string[] args)
    {
        var configurationBuilder = new ConfigurationBuilder();
        var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
        configurationBuilder.AddJsonFile(path, false);

        var root = configurationBuilder.Build();
        var connectionString = root.GetSection("ConnectionStrings").GetSection("Projeto01").Value;

        var builder = new DbContextOptionsBuilder<SqlServerContext>();
        builder.UseSqlServer(connectionString);

        return new SqlServerContext(builder.Options);
    }
}