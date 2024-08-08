namespace HF1;

internal class Alder
{
    internal static void Run()
    {
        Console.Clear();
        Console.Title = "Alder";
        {
            while (true)
            {
                Console.Write("Indtast dit navn (eller skriv 'q' for at quitte): ");
                string name = Console.ReadLine();
                
                if (name.ToLower() == "q")
                {
                    break;
                }

                
                Console.Write("Indtast din alder: ");
                string inputAge = Console.ReadLine();

                int age;
                if (int.TryParse(inputAge, out age))
                {
                    if (age < 3)
                    {
                        Console.WriteLine($"{name}, du må gå med ble");
                    }
                    else if (age >= 3 && age < 15)
                    {
                        Console.WriteLine($"{name}, du må ingenting");
                    }
                    else if (age >= 15 && age < 18)
                    {
                        Console.WriteLine($"{name}, du må drikke");
                    }
                    else if (age >= 18)
                    {
                        Console.WriteLine($"{name}, du må stemme og køre bil");
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt input for alder. Prøv igen.");
                }
            }
        }
    }
}