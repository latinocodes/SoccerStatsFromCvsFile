using System;
using System.IO;
using System.Collections.Generic;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");

            var fileContent = ReadSoccerResults(fileName);

            foreach (var content in fileContent)
            {
                Console.WriteLine(content);
            }

        }
        public static string ReadFile(string fileName){
            using(var reader = new StreamReader(fileName)){

                return reader.ReadToEnd();
            }

        }

        // Get the data from file and place it in a List of Game Results
        // return List
        public static List<GameResult> ReadSoccerResults(string fileName){
            var soccerResults = new List<GameResult>();

            using(var reader = new StreamReader(fileName))
            {

                string line = "";
                while((line = reader.ReadLine()) != null ) 
                {
                    var gameResult = new GameResult();
                    string[] values = line.Split(',');
                    DateTime gameDate;

                    if(DateTime.TryParse(values[0], out gameDate))
                    {
                        gameResult.GameDate = gameDate;
                    }
                    gameResult.TeamName = values[1];

                    HomeOrAway homeOrAway;
                    if(Enum.TryParse(values[2], out homeOrAway)){
                        gameResult.HomeORAway = homeOrAway;
                    }
                    int Int;
                    if(int.TryParse(values[3], out Int)){
                        gameResult.Goals = Int;
                    }
                    if (int.TryParse(values[4], out Int))
                    {
                        gameResult.GoalAttemps = Int;
                    }
                    if (int.TryParse(values[5], out Int))
                    {
                        gameResult.ShotsOnGoals = Int;
                    }
                    if (int.TryParse(values[6], out Int))
                    {
                        gameResult.ShotsOffGoal = Int;
               
                    }
                    double percent;
                    if(double.TryParse(values[7], out percent)){
                        gameResult.PossessionPercent = percent;
                    }

                    soccerResults.Add(gameResult);
                }

            }
            return soccerResults;
        }
    }
}