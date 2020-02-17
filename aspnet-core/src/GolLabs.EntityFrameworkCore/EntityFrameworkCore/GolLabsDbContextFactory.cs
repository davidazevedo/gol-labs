using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GolLabs.Configuration;
using GolLabs.Web;

namespace GolLabs.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GolLabsDbContextFactory : IDesignTimeDbContextFactory<GolLabsDbContext>
    {
        public GolLabsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GolLabsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GolLabsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GolLabsConsts.ConnectionStringName));

            return new GolLabsDbContext(builder.Options);
        }
    }
}
