using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {
        public DateTime DateReservation { get; set; }
        public float Prix { get; set; }
        public Passenger Passenger { get; set; }
        public Ticket Ticket { get; set; }

        [ForeignKey(nameof(Ticket))]
        public int ticketfk { get; set; }
        [ForeignKey(nameof(Passenger))]
        //[ForeignKey("Passenger")]
        public String passengerfk { get; set; }
    }
}
