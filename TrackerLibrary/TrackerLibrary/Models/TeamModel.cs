using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Mdels
{
    public class TeamModel
    {
        public int id { get; set; }
        public string teamName { get; set; }
        public List<PersonModel> teamMembers { get; set; } = new List<PersonModel>();


    }
}
