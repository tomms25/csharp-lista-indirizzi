using System;
namespace csharp_lista_indirizzi

    
{
    public const string InputFile = "..\\..\\..\\addresses.csv";
    public const string OutputFile = "..\\..\\..\\NuovaLista.txt";

    public static IEnumerable<Indirizzo> Read()
    {
        var input = File.OpenText(InputFile);
        var indirizzi = new List<Indirizzo>();
        input.ReadLine();

        while (!input.EndOfStream)
        {
            try
            {
                string? line = input.ReadLine();

                var chunks = line.Split(",");

                if (chunks.Length == 6)
                {
                    for (int i = 0; i < chunks.Length; i++)
                    {
                        if (chunks[i] == "")
                        {
                            chunks[i] = "Elemento mancante";
                        }
                    }
                    var nome = chunks[0];
                    var cognome = chunks[1];
                    var via = chunks[2];
                    var citta = chunks[3];
                    var provincia = chunks[4];
                    var codice = chunks[5];

                    var indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, codice);
                    indirizzi.Add(indirizzo);
                }
                else
                {
                    indirizzi.Add(null);
                }
            }
            catch { }
        }
        return indirizzi;
    }
    public static void Write(IEnumerable<Indirizzo> indirizzi)
    {
        using var output = File.CreateText(OutputFile);
        output.WriteLine("Lista degli Indirizzi:");

        foreach (var indirizzo in indirizzi)
        {
            if (indirizzo != null)
            {
                var nl = Environment.NewLine;
                string result = $"Nome: {indirizzo.Name}" + nl
               + $"Cognome: {indirizzo.Cognome}" + nl
               + $"Via: {indirizzo.Via}" + nl
               + $"Città; {indirizzo.Citta}" + nl
               + $"Provincia: {indirizzo.Provincia}" + nl
               + $"CAP: {indirizzo.CodicePostale}";
                output.WriteLine();
                output.WriteLine(result);
            }
            else
            {
                output.WriteLine();
                output.WriteLine("Dati non sufficienti");
            }
        }
    }
}

