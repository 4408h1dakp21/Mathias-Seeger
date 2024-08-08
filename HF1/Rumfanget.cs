namespace HF1;

    internal class RumfangBeregner
    {
        internal static void Run()
        {
            Console.Clear();
            Console.Title = "Rumfanget";
            {
                while (true)
                {
                    Console.Write("Indtast længde i cm (eller 'q' for at quitte): ");
                    string inputL = Console.ReadLine();

                    if (inputL.ToLower() == "q")
                    {
                        break;
                    }

                    try
                    {
                        double l = double.Parse(inputL);

                        Console.Write("Indtast bredde i cm: ");
                        string inputB = Console.ReadLine();
                        double b = double.Parse(inputB);

                        Console.Write("Indtast højde i cm: ");
                        string inputH = Console.ReadLine();
                        double h = double.Parse(inputH);

                        double v = h * b * l;

                        Console.WriteLine($"Rumfanget er: {v:F2} cm3");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ugyldig indtastning. Prøv igen!");
                    }
                }
            }
        }
    }
