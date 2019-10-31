using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.GameTic.EntityFrameworkCore
{
    public static class GameTicDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GameTicDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GameTicDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
