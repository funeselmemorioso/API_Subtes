using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace subtes.Models
{
    public class Linea
    {
        public string Trip_Id { get; set; }
        public string Route_Id { get; set; }
        public int Direction_ID { get; set; }
        public string start_time { get; set; }
        public string start_date { get; set; }
        public List<Estacion> Estaciones { get; set; }

    }
}