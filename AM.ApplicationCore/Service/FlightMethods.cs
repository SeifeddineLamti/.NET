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

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType) {
                case "Destination":
                    foreach (Flight f in flights)
                    {
                        if (f.Destination == filterValue)
                        {
                            Console.WriteLine(f.FlightId + " " + f.Destination + " " + f.Departure + " " + f.FlightDate);
                        }
                    }
                    break;
                case "Departure":
                        foreach (Flight f in flights)
                        {
                            if (f.Departure == filterValue)
                            {
                                Console.WriteLine(f.FlightId + " " + f.Destination + " " + f.Departure + " " + f.FlightDate);
                            }
                        }
                    break;
                case "EffectiveArrival":
                    foreach (Flight f in flights)
                    {
                        if (f.EffectiveArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(f.FlightId + " " + f.Destination + " " + f.Departure + " " + f.FlightDate);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight f in flights)
                    {
                        if (f.EstimatedDuration ==  int.Parse(filterValue))
                        {
                            Console.WriteLine(f.FlightId + " " + f.Destination + " " + f.Departure + " " + f.FlightDate);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(f.FlightId + " " + f.Destination + " " + f.Departure + " " + f.FlightDate);
                        }
                    }
                    break;

            }
        }
    }
    
}
