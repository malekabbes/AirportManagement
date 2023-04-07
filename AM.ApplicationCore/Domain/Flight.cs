using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }  
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        virtual public List<Ticket> ticket { get; set; }


        [ForeignKey("Plane")]
        virtual public int? PlaneId { get; set; }

        virtual public Plane? plane { get; set; }
        
        virtual public IList<Passanger> passangers { get; set; }
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration}";
        }
    }
}
