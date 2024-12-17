using System.Linq;

static class RozszerzeniaOsob
{
    public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
    {
        var posortowane = osoby.OrderBy(o => o.Nazwisko).ToList();
        foreach (var osoba in posortowane)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
    }
}
