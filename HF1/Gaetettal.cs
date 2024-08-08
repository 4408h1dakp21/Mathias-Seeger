namespace HF1;
internal class Gaetettal
{
    internal static void Run()
    {
        Console.Clear();
        Console.Title = "Gæt et tal mellem 1-100";
        {

            Random random = new Random();
            int secretNumber = random.Next(1, 101); 

            int attempts = 0;

            while (true)
            {
                Console.Write("Gæt på tallet (eller skriv 'q' for at quitte): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                int guess;
                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Tallet er højere end det du gættede!");
                        Console.WriteLine();
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Tallet er lavere end det du gættede!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Tillykke! Du gættede tallet!");
                        Console.WriteLine();

                        if (attempts == 1)
                        {
                            Console.WriteLine("Wow, du er et geni! Du gættede det på første forsøg!");
                        }
                        else if (attempts <= 3)
                        {
                            Console.WriteLine("Godt arbejde! Du gættede det på " + attempts + " forsøg.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Det tog lidt tid, men du nåede det til sidst! Du gættede det på " +
                                              attempts + " forsøg.");
                            Console.WriteLine();
                        }

                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt input. Prøv igen.");
                }
            }
        }
    }
}