using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.DataAccess;
using System;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService reservationService;
        public ReservationsController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("GetReservations")]
        public IActionResult GetReservations()
        {
            var result = reservationService.GetReservation();
            return Ok();
        }

        [HttpGet("GetReservationsById")]
        public IActionResult GetReservationsById(int id)
        {
            var result = reservationService.GetReservationById(id);
            return Ok(result);
        }
    }
}
