using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace subtes.Models
{
    public class Estacion
    {
        public string stop_id { get; set; }
        public string stop_name { get; set; }
        public Arrival arrival { get; set; }
        public Departure departure { get; set; }

    }
}