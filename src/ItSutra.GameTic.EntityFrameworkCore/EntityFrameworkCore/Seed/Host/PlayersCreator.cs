using ItSutra.GameTic.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItSutra.GameTic.EntityFrameworkCore.Seed
{
    class PlayersCreator
    {
        private readonly GameTicDbContext _context;

        public PlayersCreator(GameTicDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            Create();
        }

        public void Create()
        {
            var currentPlayer = _context.Players.FirstOrDefault(p => p.FirstName == null);
            if (currentPlayer == null)
            {
                _context.Players.Add(
                    new Player
                    {
                        FirstName = "Demo",
                        LastName = "Demo",
                        Winning = 0,
                        Loss=0,
                        Ties=0,
                        score =0
                    }
                    );
            }
        }
    }
}
