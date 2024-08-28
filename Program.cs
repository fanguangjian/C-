// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);

using System.Data;
using System.Text.Json;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace HelloWorld
{  
   
    internal static class Program {
        static void Main(string[] args)
        {

            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DataContextDapper dapper = new DataContextDapper(config);

            string computerJson = File.ReadAllText("Computers.json");

            // Console.WriteLine(computerJson);
            JsonSerializerOptions options = new JsonSerializerOptions(){
                // PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseUpper

            };
            // class System.Text.Json.JsonSerializer
            // IEnumerable<Computer>? computers = JsonSerializer.Deserialize<IEnumerable<Computer>>(computerJson, options);
            // package Newtonsoft Json  
            IEnumerable<Computer>? computers = JsonConvert.DeserializeObject<IEnumerable<Computer>>(computerJson);
   

            if(computers != null){
                foreach (Computer com in computers)
                {
                    // Console.WriteLine(com.Motherboard);
                }
            }

            JsonSerializerSettings settings = new JsonSerializerSettings(){
                ContractResolver = new CamelCasePropertyNamesContractResolver()
      

            };

            string computerCopNewtonsoft = JsonConvert.SerializeObject(computers, settings);
            File.WriteAllText("computerCopNewtonsoft.txt", computerCopNewtonsoft);

            
            string computerCopySystem = System.Text.Json.JsonSerializer.Serialize(computers, options);
            File.WriteAllText("computerCopySystem.txt", computerCopySystem);
        }
    }
    
}
