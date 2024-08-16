// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);

using HelloWorld.Models;


namespace HelloWorld
{  
   
    internal static class Program {
        static void Main(string[] args)
        {

            Computer myComputer = new Computer(){
                Motherboard = "Z333",
                HasWifi = true,
                HasLTE = false,
                ReleasesDate = DateTime.Now,
                Price = 888.89m,
                VideoCard = "RRR 556"

            };
            Console.WriteLine(myComputer.Price);
            // Console.WriteLine("AAA:");

            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;"
            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id= SA;Password=SQLfantuan1";
            
            // IDbconnection dbConnection = new SqlConnection(connectionString);



        
        }
    }
    
}
