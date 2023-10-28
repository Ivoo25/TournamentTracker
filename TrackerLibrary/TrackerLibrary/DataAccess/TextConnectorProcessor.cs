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

        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.id},{p.placeNumber},{p.placeName},{p.prizeAmount},{p.prizePercentage}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }
    }
}
// * Load the text file
// * Convert the text to List<PrizeModel>
// Find the max ID
//Add the new record with the new ID (max + 1)
// Convert the prizes to List<string>
// Save the List<string> to the text file