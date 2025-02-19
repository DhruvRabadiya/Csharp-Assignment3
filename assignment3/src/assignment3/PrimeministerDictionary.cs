using System.Drawing;

class PrimeministerDictionary
{
    static void Main(string[] args)
    {
        Dictionary<int, String> PrimeministerDictionary = new Dictionary<int, string>{
            { 1998,"Atal Bihari Vajpayee"},
            {2014,"Narendra Modi"},
            {2004,"Manmohan Singh"}
        };

        Console.Write("\nPrime Minister of 2004:");
        if (PrimeministerDictionary.ContainsKey(2004))
        {
            Console.WriteLine($" {PrimeministerDictionary.GetValueOrDefault(2004)}");
        }
        else
        {
            Console.WriteLine("Data doesn't exist in Dictionary");
        }

        Console.WriteLine("\nAdding current Prime Minster");
        PrimeministerDictionary.Add(2025, "Narendra Modi");
        Console.WriteLine($"Current Prime minster added: {PrimeministerDictionary.GetValueOrDefault(2025)}");

        Console.WriteLine("\nSorted Dictionary");
        var sortedDictionary = PrimeministerDictionary.OrderBy(p => p.Key);
        foreach (var sortdata in sortedDictionary)
        {
            Console.Write($"{sortdata.Key}: {sortdata.Value}\n");
        }

    }
}