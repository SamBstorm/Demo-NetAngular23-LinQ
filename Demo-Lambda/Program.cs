
using System.Threading.Tasks.Dataflow;

int value = -15;

static bool Analyse(Func<int,bool> formule, int value) {
    return formule(value);
}

Func<int, bool> estDivisiblePar3 = val => val % 3 == 0;
Func<int, bool> estDivisiblePar2 = val => val % 2 == 0;


Console.WriteLine( $"{value} est divisible par 3 : {Analyse(estDivisiblePar3, value)}");
Console.WriteLine( $"{value} est divisible par 2 : {Analyse(estDivisiblePar2, value)}");
Console.WriteLine( $"{value} est superieur à 0 : {Analyse( val => val > 0 , value)}");

static int[] AnalyseTab(Func<int, bool> formule, params int[] values) { 
    List<int> list = new List<int>();
    foreach ( int value in values )
    {
        if (formule(value))
        {
            list.Add(value);
        }
    }
    return list.ToArray();
}

int[] result_par3 = AnalyseTab(estDivisiblePar3, -15, 42, 11, 9, 7, 21, -6, 32);
Console.WriteLine("Les nombres divisible par 3 sont :");
foreach (int number in result_par3)
{
    Console.WriteLine(number);
}


int[] result_par2 = AnalyseTab(estDivisiblePar2, -15, 42, 11, 9, 7, 21, -6, 32);
Console.WriteLine("Les nombres divisible par 2 sont :");
foreach (int number in result_par2)
{
    Console.WriteLine(number);
}

int[] result_sup0 = AnalyseTab(val => val > 0, -15, 42, 11, 9, 7, 21, -6, 32);
Console.WriteLine("Les nombres supérieurs à 0 sont :");
foreach (int number in result_sup0)
{
    Console.WriteLine(number);
}

static int[] Transform(Func<int,int> formule, params int[] values)
{
    List<int> result = new List<int>();
    foreach(int value in values)
    { 
        result.Add(formule(value)); 
    }
    return result.ToArray();
}

int[] result_divPar5 = Transform(val => val / 5, -15, 42, 11, 9, 7, 21, -6, 32);
Console.WriteLine("Mes nombres après division par 5 :");
foreach (int number in result_divPar5)
{
    Console.WriteLine(number);
}


int[] result_carre = Transform(val => val * val, -15, 42, 11, 9, 7, 21, -6, 32);
Console.WriteLine("Mes nombres après mise au carré :");
foreach (int number in result_carre)
{
    Console.WriteLine(number);
}