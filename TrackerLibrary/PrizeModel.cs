using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// 1,2,3rd place
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// strings saying "first", 'second" etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// How much the prize is
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// What the prize percentage is
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
