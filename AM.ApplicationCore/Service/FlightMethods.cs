using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;

namespace AM.ApplicationCore.Service
{
    public class FlightMethods : IFlightMethods
    {
        
        public List<Flight> flights = new List<Flight>();
    
        public List<DateTime> GetFlightDate(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (Flight f in flights)
            {
                if (f.Destination == destination)
                {
                    dates.Add(f.FlightDate);
                }
            }
            return dates;
        }
    }
    
}
