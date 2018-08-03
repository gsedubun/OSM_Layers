using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace tracking.Models
{
    public class AirportRepository{
        private const string connstring  = "Data Source=.\\sqlexpress;Initial Catalog=OSM_DB;user id=sa; password=del123";
        private SqlConnection Connection;
        public AirportRepository()
        {
            this.Connection = new SqlConnection(connstring);
        }

        public IEnumerable<Airport> Search(string name){
            name = "%"+name+"%";
            var data  = Connection.Query<Airport>(@"select top 100 Name,Code,Latitude,Longitude,City,Country from airports 
                                where name like @name", new {name});
            if(data!=null)
            {
                return data;
            }
            return null;
        }
    }
}