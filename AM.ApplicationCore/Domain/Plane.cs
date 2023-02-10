using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,Airbus
    }
    public class Plane
    {
        public Plane() { }
        public int PlaneId { get; set; }    
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        public IList<Flight> flights { get; set; }
        public override string ToString()
        {
            return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
    }
}
