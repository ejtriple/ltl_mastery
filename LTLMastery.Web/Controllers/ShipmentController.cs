using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTLMastery.Web.DataContext;
using LTLMastery.Web.Models;
using LTLMastery.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LTLMastery.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentService _shipmentService;

        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PotentialShipment> GetShipments()
        {
            List<PotentialShipment> result;

            try
            {
                result = _shipmentService.GetShipments();
            }
            catch
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("results")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ShippingResults> GetResults()
        {
            ShippingResults result;

            try
            {
                result = _shipmentService.GetShippingResults();
            }
            catch
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
