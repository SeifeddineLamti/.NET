using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public String classe {  get; set; }
        public String destination { get; set; }
        public int Id { get; set; }
        public ICollection<ReservationTicket> Reservations { get; set; }
    }
}
