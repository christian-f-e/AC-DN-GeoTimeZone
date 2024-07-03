using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GeoTmZone
    {            
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string location { get; set; }
        public string country_iso { get; set; }
        public string iana_timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public string dst_abbreviation { get; set; }
        public string offset { get; set; }
        public object dst_offset { get; set; }
        public DateTime current_local_datetime { get; set; }
        public DateTime current_utc_datetime { get; set; }
    
}
}
