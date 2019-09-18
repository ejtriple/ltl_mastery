using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LTLMastery.Web.Models
{
    public class Truck
    {
        public int TruckId { get; set; }

        public int MaxCapacity { get; set; }
        
        [NotMapped]
        public int RemainingCapacity { get; set; }

        public Truck(int truckId, int maxCapacity)
        {
            TruckId = truckId;
            MaxCapacity = maxCapacity;
            RemainingCapacity = maxCapacity;
        }



    }
}
