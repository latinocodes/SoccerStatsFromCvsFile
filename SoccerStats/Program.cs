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
            var fileName = Path.Combine(directory.FullName, "data.txt");

            var fileContent = ReadSoccerResults(fileName);

            foreach (var cont in fileContent){
                Console.WriteLine(cont);
            }

        }

        public static string ReadFile(string fileName){
            using(var reader = new StreamReader(fileName)){

                return reader.ReadToEnd();
            }

        }
        public static List<string[]> ReadSoccerResults(string fileName){
            var soccerResults = new List<string[]>();
            using(var reader = new StreamReader(fileName)){

                string line = "";
                while((line = reader.ReadLine()) != null ) {

                    string[] values = line.Split(',');
                    soccerResults.Add(values);
                }

            }
            return soccerResults;
        }
    }
}
