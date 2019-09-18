using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTLMastery.Web.Models
{
    public class ShippingResults
    {
        public List<Shipment> ShippedShipments { get; set; } 
        public List<Shipment> UnshippedShipments { get; set; }
        public List<Truck> Trucks {get; set;}

        public int UnshippedCapacity => UnshippedShipments.Sum(x => x.Capacity);
        public int ShippedCapacity => ShippedShipments.Sum(x => x.Capacity);
        public int RemainingTruckCapacity => Trucks.Sum(x => x.RemainingCapacity);

        public ShippingResults()
        {
            ShippedShipments = new List<Shipment>();
            UnshippedShipments = new List<Shipment>();
            Trucks = new List<Truck>();
        }

    }
}
