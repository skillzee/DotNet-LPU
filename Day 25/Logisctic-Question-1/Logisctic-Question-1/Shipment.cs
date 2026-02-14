using Logisctic_Question_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


//Implement the following class structure :
//Class: Shipment
//Property Name
//Datatype
//Access Modifier
//ShipmentCode
//string
//public
//TransportMode
//string
//public
//Weight
//double
//public
//StorageDays
//int
//public



namespace Logisctic_Question_1
{
    public class Shipment
    {

        public string ShipmentCode { get; set; }
        public string TransportMode { get; set; }
        public double Weight { get; set; }
        public int StorageDays { get; set; }


    }
}
