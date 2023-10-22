using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Mdels
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the set of teams that were involved in this matchup.
        /// </summary>
        public List<MatchupEntryModel> entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the matchup.
        /// </summary>
        public TeamModel winner { get; set; }

        /// <summary>
        /// Represents the round number that this matchup is a part of.
        /// </summary>
        public int matchupRound { get; set; }
    }
}
