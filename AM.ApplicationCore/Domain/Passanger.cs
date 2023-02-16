using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passanger

    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]

        public int PassportNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 25 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Telephone Number")]

        [Required]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Tel number must contain 8 digits")]
        public int TelNumber { get; set; }
        

        public List<Flight> flights { get; set; }
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
