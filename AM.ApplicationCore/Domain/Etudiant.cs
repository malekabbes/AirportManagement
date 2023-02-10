using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Etudiant:Personne
    {
        public int Matricule { get; set; }
        public string Specialite { get; set; }
        public override void GetMyType()
        {
            Console.WriteLine("Am a Student");
        }
    }
}
