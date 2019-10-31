using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItSutra.GameTic.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.GameTic.GameTic.Dtos
{
    [AutoMapFrom(typeof(Player))]
    public class PlayersListDto : FullAuditedEntityDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Winning { get; set; }
        public int Loss { get; set; }
        public int Ties { get; set; }
        public int score { get; set; }
    }
}
