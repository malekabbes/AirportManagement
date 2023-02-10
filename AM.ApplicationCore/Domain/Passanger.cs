using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passanger
    {
       public DateTime BirthDate { get; set; }
       public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber}";
        }
        public virtual void PassangerType()
        {
            Console.WriteLine("I am a Passenger");

        }
        public bool CheckProfil(string firstname, string lastname, string emailadress = null)
        {
            if (emailadress == null)
            {
                return FirstName == firstname && LastName == lastname;

            }
            else
            {
                return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;

            }
        }
    }

}
