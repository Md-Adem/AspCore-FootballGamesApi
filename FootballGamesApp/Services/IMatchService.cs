using FootballGamesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballGamesApp.Services
{
    public interface IMatchService
    {
        public Task<StandingsResponseModel> GetStanding();
    }
}
