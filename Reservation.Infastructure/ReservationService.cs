using Reservation.DataAccess;
using Reserviaton.Models;
using System;

namespace Reservation.Business
{
    public class ReservationService : IReservationService
    {
        public void Create(ReservationDTO reservation)
        {
            throw new NotImplementedException();
        }

        public ReservationDTO GetReservation()
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(1000, 10000),
                ResDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                OwnerContact = Guid.NewGuid(),
                Amount = (new Random()).Next(1000, 10000)
            };
        }

        public ReservationDTO GetReservationById(int Id)
        {
            return new ReservationDTO()
            {
                Id = Id,
                ResDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                OwnerContact = Guid.NewGuid(),
                Amount = (new Random()).Next(1000, 10000)
            };
        }
    }
}
