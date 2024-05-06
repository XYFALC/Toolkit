using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    public class HourlyData
    {
        public List<string> ?Time { get; set; }
        public List<double> ?Temperature_2m { get; set; }

    }

    public class HourlyUnits
    {
        public string ?Time { get; set; }
        public string ?Temperature_2m { get; set; }
    }

    public class WeatherData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Generationtime_ms { get; set; }
        public int Utc_offset_seconds { get; set; }
        public string ?Timezone { get; set; }
        public string ?Timezone_abbreviation { get; set; }
        public double Elevation { get; set; }
        public HourlyUnits ?Hourly_units { get; set; }
        public HourlyData ?Hourly { get; set; }
    }
}
