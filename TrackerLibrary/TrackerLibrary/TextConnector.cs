using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel createPrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
