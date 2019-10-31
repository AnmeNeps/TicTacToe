using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.GameTic.GameTic.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.GameTic.GameTic
{

    interface IPlayerService : IApplicationService
    {
        Task<ListResultDto<PlayersListDto>> GetPlayerAsync(GetPlayersInput input);

        Task CreatePlayer(CreatePlayersInput input);

        Task DeletePlayer(EntityDto input);
        //Task UpadatedPlayer(UpdatePlayerInput input);

        Task<UpdatePlayerOutput> UpadatePlayer(EntityDto input);
    }
}
