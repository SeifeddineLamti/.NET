// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Service;
FlightMethods fm = new FlightMethods();
fm.flights=TestData.listFlights;
foreach (DateTime date in fm.GetFlightDate("Paris"))
    {
    Console.WriteLine(date);
}