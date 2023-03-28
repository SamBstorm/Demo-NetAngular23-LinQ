using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Extensions
{
    public static class Mapper
    {
        public static Professeur ToProf( this Personne personne)
        {
            if (personne is null) return null;
            return new Professeur() { 
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                Age = DateTime.Now.Year - personne.DateNaissance.Year,
                Email = personne.Email
            };
        }
    }
}
