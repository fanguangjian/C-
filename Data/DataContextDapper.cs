using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace HelloWorld.Data
{
    public class DataContextDapper{
        // private IConfiguration _config;
        private string _connectionString;

        public DataContextDapper(IConfiguration config){
            // _config = config;
            _connectionString = config.GetConnectionString("DefaultConnection");
        }
        
        // private string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id= SA;Password=SQLfantuan1";

     
        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            // IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return dbConnection.Query<T>(sql);
        }   

        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            // IDbConnection dbConnection = new SqlConnection(_connectionString);
            // IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return dbConnection.QuerySingle<T>(sql);
        }   

        public bool ExecuteSql(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            // IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return ( dbConnection.Execute(sql) > 0 );
        }   

        public int ExecuteSqlWithRowCount(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            // IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return dbConnection.Execute(sql);
        }   
    }

}