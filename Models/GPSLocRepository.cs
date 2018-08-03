using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace tracking.Models
{
    public class GPSLocRepository {
        private const string connString = "Data Source=.\\sqlexpress;Initial Catalog=OSM_DB;user id=sa; password=del123";
        private SqlConnection Connection;

        public GPSLocRepository()
        {
            this.Connection = new SqlConnection(connString);
        }

        public IEnumerable<UserLocation> GetUserLocation(string userName){
           var data =  Connection.Query<UserLocation>(@"select top 100 
	gps.FTime
	,gps.FLatitude
	,gps.Flongitude 
	,UserName
	,FullName
from USER_LOCATION gps
 where UserName=@userName", new {userName});

           if(data != null)
                return data;
            
            return null;
        }
    }
}