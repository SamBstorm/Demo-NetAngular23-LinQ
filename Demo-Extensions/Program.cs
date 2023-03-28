// See https://aka.ms/new-console-template for more information
using Demo_Extensions;

Personne p_1 =  new Personne() { Nom = "Legrain", Prenom = "Samuel", Email = "samuel.legrain@bstorm.be", Phone = "+3280033800", Nationalite= "Belge", RegistreNational = "87092712345", DateNaissance = new DateTime(1987,9,27)};

Professeur pro_1 = p_1.ToProf();

Console.WriteLine( pro_1.Presentation());