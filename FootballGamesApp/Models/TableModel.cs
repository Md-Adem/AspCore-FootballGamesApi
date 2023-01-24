using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballGamesApp.Models
{
    public class TableModel
    {

        public int position { get; set; }
        public TeamModel team { get; set; }
        public int playedGames { get; set; }
        public int form { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int points { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
    }

 
}
