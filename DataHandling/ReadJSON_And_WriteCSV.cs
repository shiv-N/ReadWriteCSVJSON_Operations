using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace DataHandling
{
    class ReadJSON_And_WriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = @"C:\Users\SAURABH\source\repos\Tasks\DataHandling\DataHandling\Utility\export.json";
            string exportFilePath = @"C:\Users\SAURABH\source\repos\Tasks\DataHandling\DataHandling\Utility\JsonData.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));

            Console.WriteLine("********************Now reading from json file and write to csv file***********************");
            // writing csv file
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
