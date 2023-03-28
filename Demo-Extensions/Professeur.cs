using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Extensions
{
    public class Professeur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string Presentation() {
            return $"Bonjour, je suis votre professeur, Mr. {this.Nom}. Prenez votre cahier page 42...";
        }
    }
}
