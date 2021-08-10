using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// list of the entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// which team won
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round it is.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}