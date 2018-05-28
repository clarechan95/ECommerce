using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Clare.ECommerce.EntityFrameworkCore
{
    public static class ECommerceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ECommerceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ECommerceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
