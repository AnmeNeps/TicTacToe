namespace ItSutra.GameTic.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly GameTicDbContext _context;

        public InitialHostDbBuilder(GameTicDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new PlayersCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
