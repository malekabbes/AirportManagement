using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passanger
    {
      public string HealthInformation { get; set; }
      public string Nationality { get; set; }
        public override string ToString()
        {
            return $"HealthInformation: {HealthInformation}, Nationality: {Nationality}";
        }
    }
}
