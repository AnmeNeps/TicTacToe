using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.AutoMapper;
using ItSutra.GameTic.Game;
using ItSutra.GameTic.GameTic.Dtos;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Abp.Extensions;
using Abp.Collections.Extensions;
using Abp.Linq.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace ItSutra.GameTic.GameTic
{
    class PlayerService : GameTicAppServiceBase, IPlayerService
    {
        private readonly IRepository<Player> _playerRepository;

        public PlayerService(IRepository<Player> playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task CreatePlayer(CreatePlayersInput input)
        {
            var players = ObjectMapper.Map<Player>(input);
            await _playerRepository.InsertAsync(players);
        }

        public async Task DeletePlayer(EntityDto input)
        {
            await _playerRepository.DeleteAsync(input.Id);
        }

        public async Task<ListResultDto<PlayersListDto>> GetPlayerAsync(GetPlayersInput input)
        {
            var playerLists = await _playerRepository
               .GetAll()
               .WhereIf(
                   !input.Filter.IsNullOrEmpty(),
                   e => e.Id.ToString().Contains(input.Filter)
                   )
               .ToListAsync();
            return new ListResultDto<PlayersListDto>(ObjectMapper.Map<List<PlayersListDto>>(playerLists));

        }

        public Task<UpdatePlayerOutput> UpadatePlayer(EntityDto input)
        {
            /*ar player = _playerRepository.GetAsync(input.Id);

            ObjectMapper.Map(input, player);
            if(input.FirstName != null)
            {

            }*/
            throw new NotImplementedException();
        }

        /*public async Task UpadatedPlayer(UpdatePlayerInput input)
        {
            throw new NotImplementedException();
            *//*var player = _playerRepository.Get(input.Id);
            if (input != null)
            {

            }*//*
        }*/

        /*public async Task<UpdatePlayerOutput> UpadatePlayer(UpdatePlayerInput input)
        {
            var player = input.ObjectMapper.MapTo<Player>();
            var playerUpdated = await _playerRepository.UpdateAsync(player);
            return playerUpdated.MapTo<UpdatePlayerOutput>();
        }*/
    }
}
