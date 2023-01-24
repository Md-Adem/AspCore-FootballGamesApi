using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballGamesApp.Models
{
    public class StandingsModel
    {
        public string group { get; set; }
        public List<TableModel> table { get; set; }
    }
}
