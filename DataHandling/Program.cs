using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DataHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Read data from CSV & Write data in CSV");
            // read, write Operation of csv file
            csvHandler.ImplementCSVDataHandling();
            Console.WriteLine();

            Console.WriteLine("# Read data from CSV and write it to JSON");
            // Read data from CSV and write it to JSON
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.WriteLine();

            Console.WriteLine("# Read data from JSON and write it to CSV");
            //Read data from JSON and write it to CSV.
            ReadJSON_And_WriteCSV.ImplementJSONToCSV();
        }
    }
}
