using apihookup.helpers;
using apihookup.interfaces;
using ApiHookup.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Data;

namespace apihookup.repository
{
    public class CustomSqlRepo : ICustomSqlRepo
    {
        private readonly AppSettings _options;
        public CustomSqlRepo(IOptions<AppSettings> options)
        {
            _options = options.Value;
        }

        //execute a sql query and return as json
        public string executeQuery(string query)
        {

            //gets the connection string from appsettings.json though the AppSettings class
            string connectionString = _options.ConnectionString;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var result = sqlDataToJson(reader);
                        connection.Close();
                        return result;
                    }
                }
            }
        }

        private string sqlDataToJson(SqlDataReader dataReader)
        {
            var dataTable = new DataTable();
            dataTable.Load(dataReader);
            return JsonConvert.SerializeObject(dataTable);
            
        }
    }
}
