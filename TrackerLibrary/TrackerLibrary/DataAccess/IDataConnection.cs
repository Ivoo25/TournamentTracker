﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Mdels;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel createPrize(PrizeModel model);
        // PrizeModel is the model we are passing in, and PrizeModel is the model we are returning
        PersonModel createPerson(PersonModel model);
        // PersonModel is the model we are passing in, and PersonModel is the model we are returning

        List<PersonModel> getPerson_All();

    }
}
