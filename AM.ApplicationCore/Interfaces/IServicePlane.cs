using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane:IService<Plane>
    {
        List<Passanger> GetPassenger(Plane plane);
        List<Flight> GetFlights(int n);
        Boolean IsAvailablePlane(Flight flight, int n);

        void DeletePlanes();


}
}
