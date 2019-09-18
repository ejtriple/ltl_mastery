using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTLMastery.Web.Models
{
    public class Shipment
    {

        public int ShipmentId { get; set; }
        public int? TruckId { get; set; }

        public int Capacity { get; set; }

        public Shipment(int shipmentId, int? truckId, int capacity)
        {
            ShipmentId = shipmentId;
            TruckId = truckId;
            Capacity = capacity;
        }
    }
}
