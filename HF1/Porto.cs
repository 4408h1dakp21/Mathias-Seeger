namespace HF1;

internal class Porto
{
    internal static void Run()
    {
        Console.Clear();
        Console.Title = "Porto";
        {
            while (true)
            {
                Console.WriteLine("Længde + omkreds: Max 300 cm\nLængde: Max 120 cm, eller 150 cm mod ekstra betaling");
                Console.Write("Indsæt land (Danmark eller Sverige): ");
                string countryInput = Console.ReadLine();

                Country country;
                if (countryInput.ToLower() == "danmark")
                {
                    country = Country.Denmark;
                }
                else if (countryInput.ToLower() == "sverige")
                {
                    country = Country.Sweden;
                }
                else
                {
                    Console.WriteLine("Ikke validt land. Indtast Danmark eller Sverige.");
                    return;
                }

                Console.Write("Indsæt vægt (i gram): ");
                int weight = Convert.ToInt32(Console.ReadLine());

                PortoType portoType;

                if (weight <= 2000)
                {
                    Console.Write("Skal du sende Brev (B) eller pakke (P)? ");
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "B")
                    {
                        portoType = PortoType.Letter;
                    }
                    else if (input.ToUpper() == "P")
                    {
                        portoType = PortoType.Package;
                    }
                    else
                    {
                        Console.WriteLine("Ubrugeligt input. Indtast (B) for brev eller (P) for pakke.");
                        return;
                    }
                }
                else
                {
                    portoType = PortoType.Package;
                    Console.WriteLine("Automatisk valg af pakke, da vægt er over 2kg.");
                    Console.WriteLine();
                }

                decimal porto = CalculatePorto(country, weight, portoType);

                Console.WriteLine($"Portoen er: {porto:C2}");
                Console.WriteLine();
                Console.WriteLine("Tryk på en vilkårlig tast for at beregne ny porto. Eller tryk 'q' for at quitte");
                string quit = Console.ReadLine();
                if (quit.ToLower() == "q")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }

    private enum Country
    {
        Denmark,
        Sweden
    }

    private enum PortoType
    {
        Letter,
        Package
    }
        private static decimal CalculatePorto(Country country, int weight, PortoType portoType)
    {
        decimal porto = 0;

        if (country == Country.Denmark)
        {
            if (portoType == PortoType.Letter)
            {
                if (weight is >= 50 and <= 250)
                {
                    porto = 25;
                }
                else if (weight is > 250 and <= 500)
                {
                    porto = 50;
                }
                else if (weight is > 500 and <= 2000)
                {
                    porto = 75;
                }
                else
                {
                    throw new ArgumentException("Ubrugelig vægt for brev");
                }
            }
            else if (portoType == PortoType.Package)
            {
                if (weight is >= 50 and < 5000)
                {
                    porto = 55;
                }
                else if (weight == 5000)
                {
                    porto = 65;
                }
                else if (weight is > 5000 and < 10000)
                {
                    porto = 85;
                }
                else if (weight is > 10000 and < 25000)
                {
                    porto = 125;
                }
                else if (weight is >= 25000 and <= 35000)
                {
                    porto = 189 + 29;
                }
                else
                {
                    throw new ArgumentException("Ubrugelig vægt for pakke.");
                }
            }
        }
        else if (country == Country.Sweden)
        {
            if (portoType == PortoType.Letter)
            {
                if (weight == 100)
                {
                    porto = 50;
                }
                else if (weight == 250)
                {
                    porto = 100;
                }
                else if (weight is > 250 and <= 2000)
                {
                    porto = 150;
                }
                else
                {
                    throw new ArgumentException("Ubrugelig vægt for brev");
                }
            }
            else if (portoType == PortoType.Package)
            {
                if (weight is >= 100 and <= 1000)
                {
                    porto = 207;
                }
                else if (weight is > 1000 and <= 5000)
                {
                    porto = 301;
                }
                else if (weight is > 5000 and <= 10000)
                {
                    porto = 486;
                }
                else if (weight == 15000)
                {
                    porto = 579;
                }
                else if (weight == 20000)
                {
                    porto = 748;
                }
                else
                {
                    throw new ArgumentException("Ubrugelig vægt for pakke.");
                }
            }
        }
        
        return porto;
        }
    }