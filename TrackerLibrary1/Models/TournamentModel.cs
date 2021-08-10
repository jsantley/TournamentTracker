using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the tournament 
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Amount of entry fee
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams entered in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Prizes for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// List of the matchup rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}