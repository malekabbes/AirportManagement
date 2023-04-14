using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{

    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public List<Passanger> GetPassenger(Plane plane) {
            return GetById(plane.PlaneId).flights.SelectMany(f => f.ticket)
                .Select(t => t.passangerProp).ToList(); 
        }
        public List<Flight> GetFlights(int n) { 
         //return GetById(plane.PlaneId).flights.OrderByDescending(f => f.FlightDate).Take(n).ToList();
         return GetAll().SelectMany(p => p.flights).OrderByDescending(f => f.FlightDate).Take(n).ToList();
        
        }
        public Boolean IsAvailablePlane(Flight flight,int n)
        {
            var plane_flight = GetById(flight.PlaneId);
            var flight_plane = plane_flight.flights.Find(f => flight.FlightId == f.FlightId);
            if (flight_plane.passangers.Count()+n <= plane_flight.Capacity) return true; 
            else return false;

            //var plane = flight.plane;
            //return (flight.ticket.Count() + n <= plane.Capacity)


            //var plane = GetAll().Where(p => p.flights.Contains(flight) == true).Single();
            //var tickets = plane.flights.Where(f => f.FlightId == f.FlightId).Single().ticket.Count();
            //return plane.Capacity - tickets >=n

        }
        public void DeletePlanes()
        {
            GetAll().ToList().ForEach(p =>
            {
                if((DateTime.Now - p.ManufactureDate).TotalDays > 10*365)
                {
                    Delete(p);
                }
                Commit();

            });

            //Delete(p=>(DateTime.Now- p.ManufactureDate).TotalDays>10*365);
            
        }
    }

}
