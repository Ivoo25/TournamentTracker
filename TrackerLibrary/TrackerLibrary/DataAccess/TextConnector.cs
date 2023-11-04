using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Mdels;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        public PersonModel createPerson(PersonModel model)
        {
            // Load the text file && Convert the text to List<PrizeModel>
            List<PersonModel> people = PeopleFile.fullFilePath().loadFile().convertToPersonModels();

            // Find the max ID 
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currentId;

            //Add the new record with the new ID (max + 1)
            people.Add(model);

            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        /// <summary>
        /// Saves a new prize to the text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel createPrize(PrizeModel model)
        {
            // Load the text file && Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.fullFilePath().loadFile().convertToPrizeModels();

            // Find the max ID 
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currentId;

            //Add the new record with the new ID (max + 1)
            prizes.Add(model);

            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }

        public TeamModel createTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.fullFilePath().loadFile().convertToTeamModels(PeopleFile);
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;
            teams.Add(model);
            teams.SaveToTeamFile(TeamFile);
            return model;
        }

        public TournamentModel createTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> getPerson_All() => PeopleFile.fullFilePath().loadFile().convertToPersonModels();

        public List<TeamModel> getTeam_All() => TeamFile.fullFilePath().loadFile().convertToTeamModels(PeopleFile);
    }
}