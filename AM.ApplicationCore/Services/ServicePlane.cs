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
        public List<Flight> GetFlights(Plane plane,int n) { 
         return GetById(plane.PlaneId).flights.OrderByDescending(f => f.FlightDate).Take(n).ToList();
        }
        public Boolean IsAvailablePlane(Flight flight,int n)
        {
            var plane_flight = GetById(flight.PlaneId);
            var flight_plane = plane_flight.flights.Find(f => flight.FlightId == f.FlightId);
            if (flight_plane.passangers.Count()+n <= plane_flight.Capacity) return true; 
            else return false;
        }
        public void DeletePlanes()
        {
            GetAll().ToList().ForEach(p =>
            {
                if(DateTime.Now.Year - p.ManufactureDate.Year > 10)
                {
                    Delete(p);
                }
            });
            
        }
    }

}
