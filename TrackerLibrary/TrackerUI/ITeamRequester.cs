﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Mdels;

namespace TrackerUI
{
    public interface ITeamRequester
    {
        void teamComplete(TeamModel model);
    }
}