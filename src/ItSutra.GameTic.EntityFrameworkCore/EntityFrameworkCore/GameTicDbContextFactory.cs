using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ItSutra.GameTic.Configuration;
using ItSutra.GameTic.Web;

namespace ItSutra.GameTic.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GameTicDbContextFactory : IDesignTimeDbContextFactory<GameTicDbContext>
    {
        public GameTicDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GameTicDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GameTicDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GameTicConsts.ConnectionStringName));

            return new GameTicDbContext(builder.Options);
        }
    }
}
