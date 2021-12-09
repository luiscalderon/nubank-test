using CapitalGains.Domain.DTO;
using Newtonsoft.Json;

namespace CapitalGains.Prompt
{ 
    internal class Program
    {
        private static void Main()
        {
            //string input;
            //Console.WriteLine("Type your json request:");
            //using (var sr = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
            //{
            //    input = sr.ReadToEnd();
            //}
            
            //Console.WriteLine(input);

            string json = "[{'operation':'buy', 'unit - cost':10, 'quantity': 10000},{'operation':'sell','unit-cost':2, 'quantity': 5000},{'operation':'sell', 'unit-cost':20, 'quantity':2000},{'operation':'sell', 'unit-cost':20, 'quantity': 2000},{'operation':'sell','unit-cost':25, 'quantity': 1000}]";
            var jsonObject = JsonConvert.DeserializeObject<List<OperationDTO>>(json);



        }
    }
}
