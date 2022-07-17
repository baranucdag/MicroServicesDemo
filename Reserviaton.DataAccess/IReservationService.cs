using Reservation.Models;
using System;

namespace Reservation.DataAccess
{
    public interface IReservationService
    {
        public void Create(ReservationDTO reservation);
        public ReservationDTO GetReservation();
        public ReservationDTO GetReservationById(int Id);
    }
}
