using LTLMastery.Web.DataContext;
using LTLMastery.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTLMastery.Web.Services
{
    public interface IShipmentService
    {
        ShippingResults GetShippingResults();
        List<PotentialShipment> GetShipments();
    }

    public class ShipmentService : IShipmentService
    {

        private readonly LtlMasteryDbContext _dbContext;

        public ShipmentService(LtlMasteryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PotentialShipment> GetShipments()
        {
            return _dbContext.PotentialShipments.ToList();
        }

        public ShippingResults GetShippingResults()
        {
            var results = new ShippingResults();

            var potentialShipments = _dbContext.PotentialShipments.ToList();
            var trucks = _dbContext.Trucks.OrderByDescending(x => x.RemainingCapacity).ToList();

            foreach (var shipment in potentialShipments)
            {
                foreach( var truck in trucks)
                {
                    if( truck.RemainingCapacity >= shipment.Capacity)
                    {
                        truck.RemainingCapacity -= shipment.Capacity;
                        results.ShippedShipments.Add(new Shipment(shipment.PotentialShipmentId, truck.TruckId, shipment.Capacity));
                        break;
                    }

                    if( truck.TruckId == trucks.Last().TruckId)
                    {
                        results.UnshippedShipments.Add(new Shipment(shipment.PotentialShipmentId, null, shipment.Capacity));
                    }
                }
                trucks = trucks.OrderByDescending(x => x.RemainingCapacity).ToList();
            }

            return results;
        }

    }
}
