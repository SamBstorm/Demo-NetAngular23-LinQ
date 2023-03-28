using System.Collections;

ArrayList list = new ArrayList() { 1,42,33,"Toto",'a',123 };

IEnumerable<int> ints_cast = list.Cast<int>(); //Déclanche une Exception unable to Cast in INT32
IEnumerable<int> ints_type = list.OfType<int>();

foreach (int i in ints_type)
{
    Console.WriteLine($"{i} - {i.GetType()}");
}
