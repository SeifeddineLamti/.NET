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

        public void DestinationGroupedFlights()
        {
           // IEnumerable<IGrouping<string, Flight>> group
           var query= from f in flights
                      group f by f.Destination;
            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var f in group)
                {
                    Console.WriteLine("Decollage :"+ f.FlightDate);
                }
            }
        }
        public double DurationAverage(string destination)
        {
           var query = from f in flights
                       where f.Destination == destination
                       select f.EstimatedDuration;
            return query.Average();
            //  return Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).DefaultIfEmpty(0).Average();
        }

        public List<DateTime> GetFlightDate(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            //foreach (Flight f in flights)
            //{
            //    if (f.Destination == destination)
            //    {
            //        dates.Add(f.FlightDate);
            //    }
            //}
            //return dates;


            //var query = from f in flights
            //            where f.Destination == destination
            //            select f.FlightDate;
            //return query.ToList();
            ////type de retour de base howa enumerable
            ///
            return flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
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

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query= from f in flights
                       orderby f.EstimatedDuration descending
                       select f;
            return query;
            // return Flights.OrderByDescending(f => f.EstimatedDuration);
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            ////DateTime endDate = startDate.AddDays(7);
            //var query = from f in flights
            //            where f.FlightDate >= startDate && f.FlightDate <= endDate
            //            select f;
            //return query.Count();
            var query=from f in flights
                      where DateTime.Compare(f.FlightDate, startDate) >= 0 && (f.FlightDate - startDate).TotalDays <= 7
                      select f;
            return query.Count();

            // return Flights.Where(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7)).Count();
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
           var query = from p in flight.Passengers.OfType<Traveller>()
                       orderby p.BirthDate
                       select p;
            return query.Take(3);
            //            return flight.Passengers.OfType<Traveller>().OrderByDescending(t => t.BirthDate).Take(3);

        }

        public void ShowFlightDetails(Plane plane)
        {
            //var query = from f in flights
            //            where f.Plane == plane
            //            select new { f.FlightDate, f.Destination };.
            var query = flights.Where(f => f.Plane == plane).Select(f => new { f.FlightDate, f.Destination }).ToList();
            //foreach (var f in query)
            //{
            //    Console.WriteLine(f.FlightDate + " " + f.Destination);
            //}




        }


    }
    
}
