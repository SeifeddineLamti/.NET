// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Service;
FlightMethods fm = new FlightMethods();
fm.flights=TestData.listFlights;
fm.GetFlights("EstimatedDuration", "105");
Plane p= TestData.Airbusplane;
//foreach (DateTime date in fm.GetFlightDate("Paris"))
//    {
//    Console.WriteLine(date);
//}
//cwl
fm.ShowFlightDetails(p);
Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2022,2,1)));
Console.WriteLine(fm.DurationAverage("Paris"));
foreach (var f in fm.SeniorTravellers(TestData.flight1))
{
    Console.WriteLine(f.BirthDate);
}
Console.WriteLine("------------------------------");
fm.DestinationGroupedFlights();