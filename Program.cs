// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);

using System.Data;
using System.Text.Json;
using AutoMapper;
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

            string computerJson = File.ReadAllText("ComputersSnake.json");

            Mapper mapper = new Mapper(new MapperConfiguration((cfg) => {
                cfg.CreateMap<ComputerSnake, Computer>()
                    .ForMember(destination => destination.ComputerId, options => options.MapFrom(source => source.computer_id))
                    .ForMember(destination => destination.Motherboard, options => options.MapFrom(source => source.motherboard))
                    .ForMember(destination => destination.CPUCores, options => options.MapFrom(source => source.cpu_cores))
                    .ForMember(destination => destination.HasWifi, options => options.MapFrom(source => source.has_wifi))
                    .ForMember(destination => destination.HasLTE, options => options.MapFrom(source => source.has_lte))
                    .ForMember(destination => destination.VideoCard, options => options.MapFrom(source => source.video_card))
                    .ForMember(destination => destination.ReleaseDate, options => options.MapFrom(source => source.release_date))
                    .ForMember(destination => destination.Price, options => options.MapFrom(source => source.price * .8m));

            }));

            // Console.WriteLine(computerJson);
            JsonSerializerOptions options = new JsonSerializerOptions(){
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                // PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseUpper

            };
            // class System.Text.Json.JsonSerializer
            // IEnumerable<Computer>? computers = JsonSerializer.Deserialize<IEnumerable<Computer>>(computerJson, options);
            // package Newtonsoft Json  
            // IEnumerable<Computer>? computers = JsonConvert.DeserializeObject<IEnumerable<Computer>>(computerJson);
            // IEnumerable<Computer>? computersNewtonSoft = JsonConvert.DeserializeObject<IEnumerable<Computer>>(computerJson);

            // IEnumerable<Computer>? computersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Computer>>(computerJson , options);
            IEnumerable<ComputerSnake>? computersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<ComputerSnake>>(computerJson);

   

            if(computersSystem != null){
                IEnumerable<Computer> computerResult = mapper.Map<IEnumerable<Computer>>(computersSystem);
                Console.WriteLine("Automapper Count: " +  computerResult.Count());
                // foreach (Computer computer in computerResult)
                // {
                //     Console.WriteLine(computer.Motherboard);
                // } 

            }

            JsonSerializerSettings settings = new JsonSerializerSettings(){
                ContractResolver = new CamelCasePropertyNamesContractResolver()
      

            };        
        }

        static string EscapeSingleQuote(string input){
            string output = input.Replace("'", "''");
            return output;
        }
    }
    
}
