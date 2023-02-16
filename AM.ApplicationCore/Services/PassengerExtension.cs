using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static string UpperFullName(this Passanger passanger)
        {
            if (passanger == null)
            {
                throw new ArgumentNullException();
            }
             string firstName=passanger.FirstName;
            string lastName=passanger.LastName;
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1) ;
            return firstName +"  " + lastName;
       
             
        }
    }
}
