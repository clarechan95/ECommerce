using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Clare.ECommerce.Authorization.Roles;
using Clare.ECommerce.Authorization.Users;
using Clare.ECommerce.MultiTenancy;

namespace Clare.ECommerce.EntityFrameworkCore
{
    public class ECommerceDbContext : AbpZeroDbContext<Tenant, Role, User, ECommerceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }
    }
}
