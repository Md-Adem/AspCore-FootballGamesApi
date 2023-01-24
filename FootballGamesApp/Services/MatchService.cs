using FootballGamesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FootballGamesApp.Services
{
    public class MatchService : IMatchService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "https://api.football-data.org/v4";
        public MatchService(HttpClient http)
        {
            _http = http;
            _http.DefaultRequestHeaders.Add("X-Auth-Token", "13d9364a4a764bf78382f4db8d7792c0");
        }

        public async Task<StandingsResponseModel> GetStanding()
        {
            return await _http.GetFromJsonAsync<StandingsResponseModel>($"{_baseUrl}/competitions/PL/standings");
        }
    }
}
