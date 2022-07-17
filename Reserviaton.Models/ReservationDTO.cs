using System;

namespace Reserviaton.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public DateTime? ResDate { get; set; }

        public double Amount { get; set; }

        public Guid OwnerContact { get; set; }
    }
}
