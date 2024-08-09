using System.Data;

namespace HF1;

internal class Morse
{
    internal static void Run()
    {
        Console.Clear();
        Console.Title = "Morse";
        {
            while (true)
            {
                Console.Write("Skriv en tekst for at konvertere den til Morsekode: ");
                string input = Console.ReadLine();

                string morseCode = ConvertToMorseCode(input);

                Console.WriteLine("Morsekode: " + morseCode);
                Console.WriteLine();
                Console.WriteLine(
                    "Tryk på en vilkårlig tast for at lave en ny morsekode. Eller tryk 'q' for at quitte");
                var quit = Console.ReadKey(true);
                if (quit.KeyChar == 'q')
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }

            static string ConvertToMorseCode(string input)
            {
                string morseCode = "";

                foreach (char c in input.ToUpper())
                {
                    switch (c)
                    {
                        case 'A':
                            morseCode += ".- ";
                            break;
                        case 'B':
                            morseCode += "-... ";
                            break;
                        case 'C':
                            morseCode += "-.-. ";
                            break;
                        case 'D':
                            morseCode += "-.. ";
                            break;
                        case 'E':
                            morseCode += ". ";
                            break;
                        case 'F':
                            morseCode += "..-. ";
                            break;
                        case 'G':
                            morseCode += "--. ";
                            break;
                        case 'H':
                            morseCode += ".... ";
                            break;
                        case 'I':
                            morseCode += ".. ";
                            break;
                        case 'J':
                            morseCode += ".--- ";
                            break;
                        case 'K':
                            morseCode += "-.- ";
                            break;
                        case 'L':
                            morseCode += ".-.. ";
                            break;
                        case 'M':
                            morseCode += "-- ";
                            break;
                        case 'N':
                            morseCode += "-. ";
                            break;
                        case 'O':
                            morseCode += "--- ";
                            break;
                        case 'P':
                            morseCode += ".--. ";
                            break;
                        case 'Q':
                            morseCode += "--.- ";
                            break;
                        case 'R':
                            morseCode += ".-. ";
                            break;
                        case 'S':
                            morseCode += "... ";
                            break;
                        case 'T':
                            morseCode += "- ";
                            break;
                        case 'U':
                            morseCode += "..- ";
                            break;
                        case 'V':
                            morseCode += "...- ";
                            break;
                        case 'W':
                            morseCode += ".-- ";
                            break;
                        case 'X':
                            morseCode += "-..- ";
                            break;
                        case 'Y':
                            morseCode += "-.-- ";
                            break;
                        case 'Z':
                            morseCode += "--.. ";
                            break;
                        case '0':
                            morseCode += "----- ";
                            break;
                        case '1':
                            morseCode += ".---- ";
                            break;
                        case '2':
                            morseCode += "..--- ";
                            break;
                        case '3':
                            morseCode += "...-- ";
                            break;
                        case '4':
                            morseCode += "....- ";
                            break;
                        case '5':
                            morseCode += "..... ";
                            break;
                        case '6':
                            morseCode += "-.... ";
                            break;
                        case '7':
                            morseCode += "--... ";
                            break;
                        case '8':
                            morseCode += "---.. ";
                            break;
                        case '9':
                            morseCode += "----. ";
                            break;
                        case ' ':
                            morseCode += " / ";
                            break;
                        default:
                            morseCode += "Unknown character ";
                            break;
                    }
                }

                return morseCode.Trim();
            }
        }
    }
}