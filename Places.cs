using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp.Models
{
    public class Places
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityKey { get; set; }
        public double CityLon { get; set; }
        public double CityLat { get; set; }
    }
}
