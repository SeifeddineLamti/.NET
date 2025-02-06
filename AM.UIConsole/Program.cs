// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
Plane p=new Plane();
p.Capacity = 400;
p.ManufactureDate = DateTime.Now;
p.PlaneType = PlaneType.Boeing;
Plane P1 = new Plane(200, new DateTime(2024,04,01),2,PlaneType.Airbus);
Plane p55 = new Plane { Capacity = 600, ManufactureDate = DateTime.Now };
Passenger passenger = new Passenger { FirstName = "seif",  LastName="sepsi",EmailAdress="suiii"  };
Traveller traveller = new Traveller { HealthFormation="ss", Nationality="aaaa" };
Staff staff = new Staff { EmployementDate = DateTime.Now,Function="hawess",Salary=598 };
passenger.passengertype();
staff.passengertype();
traveller.passengertype();
Console.WriteLine(p55.ToString());