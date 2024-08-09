//Lav en porto beregner der følger denne logik for porto i danmark - brev 50g-250g = 25DKK, 250g-500g = 50DKK, 500g-5000g = 75DKK. pakke 50g-5000g = 55DKK, 5000g-10000g = 85DKK, 10000g-25000g = 125DKK, 25000g-35000g = 189DKK+29DKK, hvis den ikke indleveres
namespace HF1;
    internal class Porto
    {
        internal static void Run()
        {
            Console.Clear();
            Console.Title = "Porto";
            {
                Console.WriteLine("Længde + omkreds: Max 300 cm\nLængde: Max 120 cm, eller 150 cm mod ekstra betaling");
                Console.Write("Indsæt vægt (i gram): ");
                int weight = Convert.ToInt32(Console.ReadLine());

                PortoType portoType;
                Console.Write("Brev (B) eller Pakke (P)? ");
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

                decimal porto = CalculatePorto(weight, portoType);

                Console.WriteLine($"The porto is: {porto:C2}");
            }
        }

        internal enum PortoType { Letter, Package }

        internal static decimal CalculatePorto(int weight, PortoType portoType)
        {
            decimal porto = 0;

            if (portoType == PortoType.Letter)
            {
                if (weight >= 50 && weight <= 250)
                {
                    porto = 25;
                }
                else if (weight > 250 && weight <= 500)
                {
                    porto = 50;
                }
                else if (weight > 500 && weight <= 5000)
                {
                    porto = 75;
                }
                else
                {
                    throw new ArgumentException("Invalid weight for letter");
                }
            }
            else if (portoType == PortoType.Package)
            {
                if (weight >= 50 && weight <= 5000)
                {
                    porto = 55;
                }
                else if (weight > 5000 && weight <= 10000)
                {
                    porto = 85;
                }
                else if (weight > 10000 && weight <= 25000)
                {
                    porto = 125;
                }
                else if (weight > 25000 && weight <= 35000)
                {
                    porto = 189 + (weight > 25000 ? 29 : 0);
                }
                else
                {
                    throw new ArgumentException("Invalid weight for package");
                }
            }

            return porto;
        }
    }