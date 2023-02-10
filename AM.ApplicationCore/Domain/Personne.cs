using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateNaissance { get; set; }

        public bool Login(string nom, string password)
        {
            return nom == Nom && password == Password;
        }
        public bool Login(string nom,string password,string email)
        {
            return nom == Nom && password == Password && email == Email;
        }
        public bool Loginn(string nom, string password,string email=null)
        {
            return nom == Nom && password == Password &&
   (email == Email || email == null);
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("Am a Person");
        }


        public override string ToString()
        {
            
                return $"Id: {Id}, Nom: {Nom}, Prenom: {Prenom}, Email: {Email}, DateNaissance: {DateNaissance}";
            
        }

        public Personne(string nom, string prenom, string email, string password, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            DateNaissance = dateNaissance;
        }

        public Personne()
        {
        }
    }
}
