using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Extensions
{
    public class ProfesseurWrap
    {
        public string Nom { 
            get { return this._personne.Nom; }
            set { this._personne.Nom = value; } 
        }
        public string Prenom
        {
            get { return this._personne.Prenom; }
            set { this._personne.Prenom = value; }
        }
        public int Age { get {
                return DateTime.Now.Year - this._personne.DateNaissance.Year;
            } 
        }
        public string Email
        {
            get { return this._personne.Email; }
            set { this._personne.Email = value; }
        }

        private Personne _personne;

        public ProfesseurWrap(Personne initPersonne)
        {
            this._personne = initPersonne;
        }

        public string Presentation()
        {
            return $"Bonjour, je suis votre professeur, Mr. {this.Nom}. Prenez votre cahier page 42...";
        }
    }
}
