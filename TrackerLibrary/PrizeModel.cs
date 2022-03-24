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
        /// Represents the place number for the winner teams.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place name for the winner teams.
        /// </summary>
        /// <example>
        /// Champion, 1st runner up, etc.
        /// </example>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of prize for the winner teams
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the prize that
        /// the winners will get.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}