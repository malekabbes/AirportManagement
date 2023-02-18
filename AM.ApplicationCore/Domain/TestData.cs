using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>(){
        new Plane
        {
            Capacity=300,
            ManufactureDate=new DateTime(),
            PlaneType=PlaneType.Boing
        },
        new Plane
        {
            PlaneType=PlaneType.Airbus,
            Capacity=400,
            ManufactureDate=new DateTime(2020,11,11),
        }
        };
        public static List<Staff> Staffs { get; set; } = new List<Staff>()
        {
            new Staff
            {
                 FirstName="Captain",
                 LastName="Captain",
                 EmailAddress="captain.captain@gmail.com",
                 BirthDate=new DateTime(1965,01,01),
                 EmployementDate=new DateTime(1999,01,01),
                 Salary=99999
            }
        };
        public static List<Traveller> Travellers { get; set; } = new List<Traveller>()
        {
            new Traveller
            {
                FirstName="Traveller1",
                LastName="Traveller1",
                EmailAddress="traveller1@gmail.com",
                Nationality="Americain",
                BirthDate=new DateTime(1988,02,04)
            }
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight
            {
                Departure="Paris",
                EffectiveArrival=new DateTime(2022-12-11),
                plane=Planes[1],
                passangers=new List<Passanger>(Travellers)
            }
        };

    }
}
