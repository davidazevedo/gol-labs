using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GolLabs.EntityFrameworkCore
{
    public static class GolLabsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GolLabsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GolLabsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
