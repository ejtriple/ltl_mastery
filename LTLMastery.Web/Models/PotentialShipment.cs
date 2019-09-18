using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTLMastery.Web.Models
{
    public class PotentialShipment
    {

        public int PotentialShipmentId { get; set; }
        public int Capacity { get; set; }

        public PotentialShipment(int potentialShipmentId, int capacity)
        {
            PotentialShipmentId = potentialShipmentId;
            Capacity = capacity;
        }
    }
}
