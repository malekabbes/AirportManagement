using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.ApplicationCore.Domain
    {
        public class Ticket
        {
            
            public bool VIP { get; set; }
            public string Siege { get; set; }
            public double prix { get; set; }
            virtual public Passanger passangerProp { get; set; }
            virtual public Flight flightProp { get; set; }
            [ForeignKey(nameof(flightProp))]
            public int FlightFK { get; set; }
            [ForeignKey(nameof(passangerProp))]

            public int PassengerFK { get; set; }

        }
    }
