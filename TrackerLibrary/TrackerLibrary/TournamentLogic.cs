using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Mdels;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list randomly of teams
        // Check if it is big enough - if not, add in byes - 2*2*2*2 - 2^4
        // Create our first round of matchups
        // Create every round after that - 8 matchups - 4 matchups - 2 matchups - 1 matchup
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.enteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberofByes(rounds, randomizedTeams.Count); // 2^4 - 2^3 = 2
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currM = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                currM.entries.Add(new MatchupEntryModel { teamCompeting = team });
                if (byes > 0 || currM.entries.Count > 1)
                {
                    currM.matchupRound = 1;
                    output.Add(currM);
                    currM = new MatchupModel();
                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        private static int NumberofByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;
            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams) =>
            teams.OrderBy(x => Guid.NewGuid()).ToList();
    }
}
