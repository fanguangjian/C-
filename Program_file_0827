// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);

using System.Data;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


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
                VideoCard = "RRR 557711"

            };
            // Console.WriteLine(myComputer.Price);
            // Console.WriteLine("AAA:");

            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;"
            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id= SA;Password=SQLfantuan1";
            
            // IDbConnection dbConnection = new SqlConnection(connectionString);

            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            // DataContextDapper dapper = new DataContextDapper();
            // DataContextEF entityFramework = new DataContextEF();

            DataContextDapper dapper = new DataContextDapper(config);
            DataContextEF entityFramework = new DataContextEF(config);

            string sqlCommand = "SELECT GETDATE()";

            // DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
            // DateTime rightNow = dapper.LoadDataSingle<DateTime>(sqlCommand);


            // Console.WriteLine(rightNow);
            // entityFramework.Add(myComputer);  // Instead of the following SQL
            // entityFramework.SaveChanges();

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
            // bool res = dapper.ExecuteSql(sql);


            // Console.WriteLine(res);

            string sqlSelect = @"SELECT TOP(100)* FROM TutorialAppSchema.Computer";
            // List<Computer> computers = dbConnection.Query<Computer>(sqlSelect).ToList();
            // IEnumerable<Computer> computers = dbConnection.Query<Computer>(sqlSelect).ToList();
            IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect).ToList();
            IEnumerable<Computer>? computersEf = entityFramework.Computer?.ToList<Computer>();



            // foreach (var com in computers)
            foreach (var com in computersEf)

            {
                // Console.WriteLine(com.Motherboard);
                Console.WriteLine(
                  "'" + com.Motherboard + "','" + com.HasWifi + "'"
                );

            }

            // Console.WriteLine(computers);
            // File.WriteAllText("log.txt",sql);
            
            //  will write with no break
            // using StreamWriter openFile = new("log.txt", append: true);
            // openFile.WriteLine("\n" + sql + "\n" );
            // openFile.Close();

            string fileText = File.ReadAllText("log.txt");

            Console.WriteLine(fileText);


        }
    }
    
}
