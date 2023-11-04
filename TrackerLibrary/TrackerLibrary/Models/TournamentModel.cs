using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Mdels
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string tournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee for the tournament.
        /// </summary>
        public decimal entryFee { get; set; }

        /// <summary>
        /// Represents the set of teams that have entered the tournament.
        /// </summary>
        public List<TeamModel> enteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the set of prizes that are available for the tournament.
        /// </summary>
        public List<PrizeModel> prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the set of rounds that have been played and the matchups in each round.
        /// </summary>
        public List<List<MatchupModel>> rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
