using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusLogAPI
{
    internal class Arquivo
    {

        public class Rootobject
        {
            public Shipmentidentifier[] ShipmentIdentifiers { get; set; }
            public string Latitude { get; set; }
            public string Longitude { get; set; }
            public DateTime UtcTimestamp { get; set; }
            public string CustomerId { get; set; }
        }

        public class Shipmentidentifier
        {
            public string Type { get; set; }
            public string Value { get; set; }
        }
    }
}
