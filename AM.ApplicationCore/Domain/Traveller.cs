using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthFormation { get; set; }
        public string Nationality {  get; set; }

        public override void passengertype()
        {
            base.passengertype();
            Console.WriteLine("i am traveller");
        }
    }
}
