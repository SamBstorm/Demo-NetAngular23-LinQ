// See https://aka.ms/new-console-template for more information
static string[] Immediat(Personne[] personnes)
{
    List<string> result = new List<string>();
    foreach (Personne personne in personnes)
    {
        result.Add(personne.Nom);
    }
    return result.ToArray();
}

static IEnumerable<string> Differe(Personne[] personnes)
{
    foreach (Personne personne in personnes)
    {
        yield return personne.Nom;
    }
}

Personne[] invites = {
    new Personne(){ Nom = "Legrain", Prenom="Samuel"},
    new Personne(){ Nom = "Person", Prenom="Michael"},
    new Personne(){ Nom = "Morre", Prenom="Thierry"},
    new Personne(){ Nom = "Byas", Prenom="Sébastien"}
};

IEnumerable<string> noms_im = Immediat(invites);

IEnumerable<string> noms_dif = Differe(invites);

Console.WriteLine("Immédiat");
foreach (string nom in noms_im)
{
    Console.WriteLine(nom);
}

Console.WriteLine("Différé");
foreach (string nom in noms_dif)
{
    Console.WriteLine(nom);
}

Console.WriteLine(noms_dif);

public class Personne {
    public string Nom { get; set; }
    public string Prenom { get; set; }
}