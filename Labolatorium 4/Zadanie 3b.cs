using System.Collections.Generic;

static class RozszerzeniaOsob
{
    public static void WypiszOsoby(this List<IOsoba> osoby)
    {
        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
    }
}
