using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TrackerLibrary.Mdels;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string fullFilePath(this string fileName) => @$"{ConfigurationManager.AppSettings["filePath"]}\{fileName}";

        public static List<string> loadFile(this string file) => !File.Exists(file) ? new List<string>() : File.ReadAllLines(file).ToList();

        public static List<PrizeModel> convertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(','); // Split the line by commas, and store the result in an array
                PrizeModel p = new PrizeModel();
                p.id = int.Parse(cols[0]);
                p.placeNumber = int.Parse(cols[1]);
                p.placeName = cols[2];
                p.prizeAmount = decimal.Parse(cols[3]);
                p.prizePercentage = double.Parse(cols[4]);
                //cols: 0:id, 1: placeNumber, 2: placeName, 3: prizeAmount, 4: prizePercentage
                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> convertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(','); // Split the line by commas, and store the result in an array
                PersonModel p = new PersonModel();
                p.id = int.Parse(cols[0]);
                p.firstName = cols[1];
                p.lastName = cols[2];
                p.emailAddress = cols[3];
                p.cellphoneNumber = cols[4];
                //cols: 0:id, 1: firstName, 2: lastName, 3: emailAddress, 4: cellphoneNumber
                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> convertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id, team name, list of ids separated by the pipe
            //3, Tim's Team, 1|3|5 -> 1, 3, 5 are the ids of the team members
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.fullFilePath().loadFile().convertToPersonModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(','); // Split the line by commas, and store the result in an array
                TeamModel t = new TeamModel();
                t.id = int.Parse(cols[0]);
                t.teamName = cols[1];
                string[] personIds = cols[2].Split('|'); // Split the line by pipes, and store the result in an array

                foreach (string id in personIds)
                {
                    t.teamMembers.Add(people.Where(x => x.id == int.Parse(id)).First());
                    // what this does is that it finds the person with the id that matches the id in the personIds array, and adds it to the teamMembers list
                }
                //cols: 0:id, 1: teamName, 2: list of ids separated by the pipe
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName, string prizesFileName)
        {
            //id, TournamentName, EntryFee, (id|id|id - Entered Teams), (id|id|id - Prizes), (Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.fullFilePath().loadFile().convertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizesFileName.fullFilePath().loadFile().convertToPrizeModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(','); // Split the line by commas, and store the result in an array
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.tournamentName = cols[1];
                tm.entryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|'); // Split the line by pipes, and store the result in an array
                foreach (string id in teamIds)
                {
                    tm.enteredTeams.Add(teams.Where(x => x.id == int.Parse(id)).First());
                    // What this does is that it finds the person with the id that matches the id in the personIds array, and adds it to the teamMembers list
                }

                string[] prizesIds = cols[4].Split('|'); // Split the line by pipes, and store the result in an array
                foreach (string id in prizesIds)
                {
                    tm.prizes.Add(prizes.Where(x => x.id == int.Parse(id)).First()); // What this does is that it finds the person with the id that matches the id in the personIds array, and adds it to the teamMembers list      
                }


                output.Add(tm);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.id},{p.placeNumber},{p.placeName},{p.prizeAmount},{p.prizePercentage}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.id},{p.firstName},{p.lastName},{p.emailAddress},{p.cellphoneNumber}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.id},{t.teamName},{ConvertPeopleListToString(t.teamMembers)}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model, string MatchupFile, string MatchupEntryFile)
        {

        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id}," +
                    $"{tm.tournamentName}," +
                    $"{tm.entryFee}," +
                    $"{ConvertTeamListToString(tm.enteredTeams)}," +
                    $"{ConvertPrizeListToString(tm.prizes)}," +
                    $"{ConvertRoundListToString(tm.rounds)}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            if (people.Count == 0)
            {
                return "";
            }
            foreach (PersonModel p in people)
            {
                output += $"{p.id}|";
            }
            output = output.Substring(0, output.Length - 1); // Remove the last pipe
            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1); // Remove the last pipe
            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }
            foreach (TeamModel t in teams)
            {
                output += $"{t.id}|";
            }
            output = output.Substring(0, output.Length - 1); // Remove the last pipe
            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.id}|";
            }
            output = output.Substring(0, output.Length - 1); // Remove the last pipe
            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.id}^";
            }
            output = output.Substring(0, output.Length - 1); // Remove the last pipe
            return output;
        }
    }
}
