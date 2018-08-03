using System;

namespace tracking.Models
{
    public class UserLocation
    {
        public string FTime { get; set; }
        public string FKPT { get; set; }
        public string FLatitude { get; set; }

        public string FLongitude { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

    }

    public class Airport{
        public string Name { get; set; }
        public string Code { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

public string City { get; set; }
        public string Country { get; set; }
        
    }
}