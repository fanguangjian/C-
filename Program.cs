// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);

using System.Data;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;


namespace HelloWorld
{  
   
    internal static class Program {
        static void Main(string[] args)
        {

            Computer myComputer = new Computer(){
                Motherboard = "Z334",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 888.89m,
                VideoCard = "RRR 5577"

            };
            // Console.WriteLine(myComputer.Price);
            // Console.WriteLine("AAA:");

            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;"
            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id= SA;Password=SQLfantuan1";
            
            // IDbConnection dbConnection = new SqlConnection(connectionString);

            DataContextDapper dapper = new DataContextDapper();

            string sqlCommand = "SELECT GETDATE()";

            // DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
            DateTime rightNow = dapper.LoadDataSingle<DateTime>(sqlCommand);


            Console.WriteLine(rightNow);

            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                HasWifi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            ) VALUES (
                  '" + myComputer.Motherboard 
                  + "','" + myComputer.HasWifi 
                  + "','" + myComputer.HasLTE
                  + "','" + myComputer.ReleaseDate
                  + "','" + myComputer.Price
                  + "','" + myComputer.VideoCard

            +"')";

            // int res = dbConnection.Execute(sql);
            // int res = dapper.ExecuteSqlWithRowCount(sql);
            bool res = dapper.ExecuteSql(sql);


            Console.WriteLine(res);

            string sqlSelect = @"SELECT TOP(100)* FROM TutorialAppSchema.Computer";
            // List<Computer> computers = dbConnection.Query<Computer>(sqlSelect).ToList();
            // IEnumerable<Computer> computers = dbConnection.Query<Computer>(sqlSelect).ToList();
            IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect).ToList();


            foreach (var com in computers)
            {
                // Console.WriteLine(com.Motherboard);
                Console.WriteLine(
                  "'" + com.Motherboard + "','" + com.HasWifi + "'"
                );

            }

            // Console.WriteLine(computers);


        
        }
    }
    
}
