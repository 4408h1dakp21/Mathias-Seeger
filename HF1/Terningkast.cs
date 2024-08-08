namespace HF1;

internal class Terningkast
{
    internal static void Run()
    {
        Console.Clear();
        Console.Title = "Terningkast";
        {
            Random random = new Random();

            while (true)
            {
                Console.Write("Tryk 'enter' for at kaste terningen(ellers 'q' for at quitte): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                int terningskast = random.Next(1, 7);

                Console.WriteLine("Du slog ");

                if (terningskast == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("et");
                }
                else if (terningskast == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("to");
                }
                else if (terningskast == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("tre");
                }
                else if (terningskast == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("fire");
                }
                else if (terningskast == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("fem");
                }
                else if (terningskast == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("seks");
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}