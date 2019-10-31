using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.GameTic.Game
{
    public class Player : FullAuditedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Winning { get; set; }
        public int Loss { get; set; }
        public int Ties { get; set; }
        public int score { get; set; }

    }
}
