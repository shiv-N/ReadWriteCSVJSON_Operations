using System;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DataHandling
{
    class csvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            // Initialization.  
            string importFilePath = "C:\\Users\\SAURABH\\source\\repos\\Tasks\\DataHandling\\DataHandling\\Utility\\addresses.csv";
            string exportFilePath = "C:\\Users\\SAURABH\\source\\repos\\Tasks\\DataHandling\\DataHandling\\Utility\\export.csv";

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses.csv, here are city ");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.city);
                }
                Console.WriteLine("\n***********Now reading from csv file and write to csv file************");

                // writing csv file
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
