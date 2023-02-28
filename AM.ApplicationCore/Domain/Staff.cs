using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passanger
    {
       public DateTime EmployementDate { get; set; }
       public string Function { get; set; }
        [DataType(DataType.Currency)]

        public int Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"EmployementDate : {EmployementDate}, Function: {Function}, Salary: {Salary}";
        }

        public override void PassangerType()
        {
            base.PassangerType();
            Console.WriteLine("staf");

        }

    }
}
