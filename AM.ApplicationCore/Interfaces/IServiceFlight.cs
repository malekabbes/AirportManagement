using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public List<DateTime> GetFlightDates(String destination);
        public IEnumerable<DateTime> GettFlightDates(String destination);
        // public void GetFlights(String filterType,String filterValue)

        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public IList<Traveller> SeniorTravellers(Flight flight);
        public IList<IGrouping<string, Flight>> DestinationGroupedFlights();

}
}
