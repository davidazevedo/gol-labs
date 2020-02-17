using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GolLabs.Authorization.Roles;
using GolLabs.Authorization.Users;
using GolLabs.MultiTenancy;

namespace GolLabs.EntityFrameworkCore
{
    public class GolLabsDbContext : AbpZeroDbContext<Tenant, Role, User, GolLabsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GolLabsDbContext(DbContextOptions<GolLabsDbContext> options)
            : base(options)
        {
        }
    }
}
