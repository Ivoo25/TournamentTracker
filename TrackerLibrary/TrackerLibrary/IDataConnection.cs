using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel createPrize(PrizeModel model);
        // PrizeModel is the model we are passing in, and PrizeModel is the model we are returning
    }
}
