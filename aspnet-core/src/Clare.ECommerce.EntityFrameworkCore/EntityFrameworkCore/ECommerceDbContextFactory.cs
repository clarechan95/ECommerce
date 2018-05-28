using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Clare.ECommerce.Configuration;
using Clare.ECommerce.Web;

namespace Clare.ECommerce.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ECommerceDbContextFactory : IDesignTimeDbContextFactory<ECommerceDbContext>
    {
        public ECommerceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ECommerceDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ECommerceDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ECommerceConsts.ConnectionStringName));

            return new ECommerceDbContext(builder.Options);
        }
    }
}
