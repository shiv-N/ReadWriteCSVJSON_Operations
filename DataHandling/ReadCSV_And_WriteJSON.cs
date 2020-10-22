using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace DataHandling
{
    class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = "C:\\Users\\SAURABH\\source\\repos\\Tasks\\DataHandling\\DataHandling\\Utility\\addresses.csv";
            string exportFilePath = @"C:\Users\SAURABH\source\repos\Tasks\DataHandling\DataHandling\Utility\export.json";

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses.csv, here are codes ");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t"+addressData.code);
                }
                Console.WriteLine("\n********************Now reading from csv file and write to json file****************");

                // write data to json file.
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
