namespace HF1;

    internal class ValutaOmregner
    {
        internal static void Run()
        {
            Console.Clear();
            Console.Title = "Valuta Omregner";
            {
                while (true)
                {
                    Console.Write("Indtast danske kroner (eller 'q' for at quitte): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "q")
                    {
                        break;
                    }

                    try
                    {
                        double dkk = double.Parse(input);

                        double usd = dkk * 0.154;
                        double gbp = dkk * 0.118;
                        double eur = dkk * 0.133;
                        double sek = dkk * 1.053;

                        Console.WriteLine($"US Dollars: {usd:F2} USD");
                        Console.WriteLine($"Britiske Pund: {gbp:F2} GBP");
                        Console.WriteLine($"Euro: {eur:F2} EUR");
                        Console.WriteLine($"Svenske kroner: {sek:F2} SEK");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ugyldig indtastning. Prøv igen!");
                    }
                }
            }
        }
    }
