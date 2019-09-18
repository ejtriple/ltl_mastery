using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTLMastery.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LTLMastery.Web.DataContext
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using( var context = new LtlMasteryDbContext(serviceProvider.GetRequiredService<DbContextOptions<LtlMasteryDbContext>>()))
            {

                if( context.PotentialShipments.Any())
                {
                    return;
                }
                context.PotentialShipments.AddRange(
                    new PotentialShipment(1, 16000),
                    new PotentialShipment(2, 42000),
                    new PotentialShipment(3, 8000),
                    new PotentialShipment(4, 12000),
                    new PotentialShipment(5, 38000),
                    new PotentialShipment(6, 1200),
                    new PotentialShipment(7, 1000),
                    new PotentialShipment(8, 18000),
                    new PotentialShipment(9, 28000),
                    new PotentialShipment(10, 7500),
                    new PotentialShipment(11, 17000),
                    new PotentialShipment(12, 37000)

                );
                /*
                 * | Truck  |     Capacity         |   
| -----  |----------------------|  
|   001  |         44000        |  
|   002  |         42000        |  
|   003  |         20000        |   
|   004  |         24000        |  
                 */
                context.Trucks.AddRange(
                    new Truck(1, 44000),
                    new Truck(2, 42000),
                    new Truck(3, 20000),
                    new Truck(4, 24000)
                    );
                context.SaveChanges();
            }
        }
    }
}
