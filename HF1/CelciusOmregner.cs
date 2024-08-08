using System;



class CelciusOmregner

{

    static void Main(string[] args)

    {

        while (true)

        {

            Console.Write("Indtast temperatur i Celciusgrader (eller 'q' for at quitte): ");

            string input = Console.ReadLine();



            if (input.ToLower() == "q")

            {

                break;

            }



            try

            {

                double celcius = double.Parse(input);

                double reamur = celcius * 0.8;

                double fahrenheit = celcius * 1.8 + 32;



                Console.WriteLine($"Reamur: {reamur:F2}°Ré");

                Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");

            }

            catch (FormatException)

            {

                Console.WriteLine("Ugyldig indtastning. Prøv igen!");

            }

        }

    }

}