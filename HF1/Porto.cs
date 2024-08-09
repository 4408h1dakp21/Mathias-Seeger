//Lav en porto beregner der følger denne logik for porto i danmark - brev 50g-250g = 25DKK, 250g-500g = 50DKK, 500g-5000g = 75DKK. pakke 50g-5000g = 55DKK, 5000g-10000g = 85DKK,+ 10000g-25000g = 125DKK, 25000g-35000g = 189DKK+29DKK, hvis den ikke indleveres
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
                        Console.WriteLine("Invalid input. Please enter L for letter or P for package.");
                        return;
                    }
                }
                else
                {
                    portoType = PortoType.Package;
                    Console.WriteLine("Automatisk valg af pakke, da vægt er over 2kg.");
                    Console.WriteLine();
                }

                decimal porto = CalculatePorto(weight, portoType);

                Console.WriteLine($"Portoen er: {porto:C2}");
                Console.WriteLine();
            }
        }
    }

    private enum PortoType
    {
        Letter,
        Package
    }

    private static decimal CalculatePorto(int weight, PortoType portoType)
    {
        decimal porto = 0;

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
            else if (weight is > 500 and <= 5000)
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
            else if (weight is > 5000 and <= 10000)
            {
                porto = 85;
            }
            else if (weight is > 10000 and <= 25000)
            {
                porto = 125;
            }
            else if (weight is > 25000 and <= 35000)
            {
                porto = 189 + 29;
            }
            else
            {
                throw new ArgumentException("Ubrugelig vægt for pakke.");
            }
        }
        
        return porto;
    }
}