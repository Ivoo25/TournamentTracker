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
        /// Represents the unique identifier for the prize.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Represents the place number that this prize is for.
        /// </summary>
        public int placeNumber { get; set; }

        /// <summary>
        /// Represents the friendly name for the place that this prize is for.
        /// </summary>
        public string placeName { get; set; }

        /// <summary>
        /// Represents the fixed amount this place earns or zero if it is not used.
        /// </summary>
        public decimal prizeAmount { get; set; }

        /// <summary>
        /// Represents the number that represents the percentage of the overall take or
        /// </summary>
        public double prizePercentage { get; set; }
    }
}
