using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IFlightMethods
    {
        List<DateTime> GetFlightDate(string destination);
        void GetFlights(string filterType, string filterValue);
    }
}
