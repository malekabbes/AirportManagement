
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
    [Owned]

    public class FullName
    {
        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 25 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}";
        }
    }
}
