using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
//*Load the text file
//*Convert the text to List<prizeModel>
//Find the max ID
//Add the new record with the new ID (max +1)
//Convert the prizes to list<string>
//Save the list<string> to the text file
{
    public static class TextConnectorProcessor
    {

        /// <summary>
        /// this method takes the fileName and then gets the configuration settings from app.config file.
        /// It gets the file path and uses string concatenation to make a new fileName that it took in . 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>

        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{ fileName } ";

        }

        /// <summary>
        /// This method is of type List<string> and named LoadFile in which it takes in a string and calls it file.  
        /// if the file exits in our folder, then we get all the lines of our file and put it in a list.
        /// If the file doesn't exist yet, it returns a new instance of the List<string>
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<string> LoadFile(this string file)
        {
            if (File.Exists(file) == false)
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// This is a static class that takes in a List<PrizeModel> which is definiend in our models folder PrizeModel file.  
        /// This method is in charge of setting the properties within that file. 
        /// It loops through each line in lines (lines is taken in when we call this method.
        /// It splits each up by commas and then places these pieces of data inside this instance of PrizeModel.  
        /// We parse each number to ensure that the data is validated before entering our system. 
        /// this particular instace of List<prizemodel> is output and we add it to our overloaded class that sets our properties from the PrizeModel.cs file.
        /// 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PrizeModel> ConvertToPrizeModels (this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);


            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels (this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);

            }
            return output;
        }

        /// <summary>
        /// this is a method that takes in a instance of the list<prizemodel> and take in a string that we call fileName.
        /// We then intantiate a new instance of List<strings> called lines. 
        /// then, foreach PrizeModel instance in the models variable (which is just a List of PrizeModel)
        /// add all the lines separated by commas.  Theses lines are taken from each instance of PrizeModel's properties. 
        /// Then write all the lines, to the file name with the full file path.  The FullFilePath() returns the file path and the extention variable
        /// means that the FullFilePath extention method takes in the fileName variable contents, and then WriteAllLines writes the List of strings called lines. 
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{p.PlaceNumber },{p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
       
    }
}
