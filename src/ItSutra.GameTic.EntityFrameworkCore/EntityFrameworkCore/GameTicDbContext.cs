using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ItSutra.GameTic.Authorization.Roles;
using ItSutra.GameTic.Authorization.Users;
using ItSutra.GameTic.MultiTenancy;
using ItSutra.GameTic.Game;

namespace ItSutra.GameTic.EntityFrameworkCore
{
    public class GameTicDbContext : AbpZeroDbContext<Tenant, Role, User, GameTicDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Player> Players { get; set; }
        public object Player { get; internal set; }
        public DbSet<Match> Matches { get; set; }

        public GameTicDbContext(DbContextOptions<GameTicDbContext> options)
            : base(options)
        {
        }
    }
}
