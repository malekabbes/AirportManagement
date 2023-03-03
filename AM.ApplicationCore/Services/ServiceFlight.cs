using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();


        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }
            return dates;
        }
        public List<DateTime> GetFlightDates2(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            Flights.ForEach(f =>
            {
                if (f.Destination == destination)
                {
                    dates.Add(f.FlightDate);
                };
            }
            );
            return dates;
        }

        public IEnumerable<DateTime> GettFlightDates(string destination)
        {

            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {

                    yield return flight.FlightDate;
                }
            }

        }

        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func)
        {

            Func<string, Flight, Boolean> Condition = func;
            foreach (var item in Flights)
            {
                if (Condition(filterValue, item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        //LINQ syntaxe des requete
        public IList<DateTime> GetFlightDateslinq(string destination)
        {
            var query=from f in Flights where f.Destination == destination select f.FlightDate; 
        return query.ToList();
        }
        // Syntaxe des methodes
        public IList<DateTime> GetFlightDateslinq2(string destination) {
            var query = Flights.
           Where(f => f.Destination == destination)
           .Select(f => f.FlightDate);
            return query.ToList();

          }
        // LINQ Requete
        public void ShowFlightDetails(Plane plane)
        {
            var req = from f in Flights
                      where (f.plane == plane)
                      select new { f.FlightDate, f.Destination };
            foreach (var item in req)
            {
                Console.WriteLine(item.Destination + " " + item.FlightDate);
            }
        }
            // LINQ Des method
            public void ShowFlightDetails2(Plane plane) {

                var req = Flights.Where(f => f.plane == plane).Select(f => new { f.FlightDate, f.Destination });
                foreach (var item in req)
                {
                    Console.WriteLine(item.Destination + " " + item.FlightDate);
                }
            }
        //Retourner le nombre de vols programmés pour une semaine(7jours) à partir d’une date
        // donnée

          public int ProgrammedFlightNumber(DateTime startDate)
        {
            return Flights.Where(f => f.FlightDate > startDate && ((f.FlightDate - startDate).TotalDays < 7)).Count();
        }

        // LINQ Syntaxe
        public IList<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights orderby f.EstimatedDuration descending select f;
            return query.ToList();
        }
        // LINQ Des method
        public IList<Flight> OrderedDurationFlights2()
        {
            return Flights.OrderByDescending(f => f.FlightDate).ToList();
        }
        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            var query = (from f in Flights where f.FlightId == flight.FlightId select f).Single();
            return query.passangers.OfType<Traveller>().ToList().OrderBy(p=>p.BirthDate).Take(3).ToList();
        }
        public double DurationAverage(string destination)
        {
            //var query = from f in Flights
            //where f.Destination == destination select f;
            //return query.Average (f=>f.EstimatedDuration);
            var query = Flights
            .Where(f => f.Destination == destination)
            .Average(f => f.EstimatedDuration);
            return query;
}

        public IList<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var req = Flights.GroupBy(f => f.Destination).ToList();
            foreach(var item1 in req)
            {

                Console.WriteLine(item1.Key);
                foreach(var item2 in item1)
                {
                    Console.WriteLine("Décollage : "+item2.FlightDate);
                }
            }
            return req.ToList();
        }

      
        Action<Plane> FlightDetailsDel { get ; set; }
        Func<string, double> DurationAverageDel { get; set; }
        public ServiceFlight()
        {
            //FlightDetailsDel = ShowFlightDetails;
            DurationAverageDel = DurationAverage;
            FlightDetailsDel = plane =>
            {
                var req = from f in Flights
                          where (f.plane == plane)
                          select new { f.FlightDate, f.Destination };
                foreach (var item in req)
                {
                    Console.WriteLine(item.Destination + " " + item.FlightDate);
                }
            };
            DurationAverageDel = destination =>
            {
                var query = Flights
           .Where(f => f.Destination == destination)
           .Average(f => f.EstimatedDuration);
                return query;
            };
        
        }
  
    }

}
