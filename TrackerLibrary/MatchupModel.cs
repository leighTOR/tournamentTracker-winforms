using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of teams that entered a matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner in a matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents a round in a matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}