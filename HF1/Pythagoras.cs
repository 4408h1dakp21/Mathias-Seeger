namespace HF1;

    internal class Pythagoras
    {
        internal static void Run()
        {
                Console.Clear();
                Console.Title = "Pythagoras";
                {
                    while (true)
                    {
                        Console.Write("Indtast det første tal (eller skriv 'q' for at quitte): ");
                        string inputA = Console.ReadLine();

                        if (inputA.ToLower() == "q")
                        {
                            break;
                        }

                        double a;
                        if (double.TryParse(inputA, out a))
                        {
                            Console.Write("Indtast det andet tal: ");
                            string inputB = Console.ReadLine();

                            double b;
                            if (double.TryParse(inputB, out b))
                            {
                                double c = a * a + b * b;

                                Console.WriteLine($"{a}² + {b}² = {c}²");
                                Console.WriteLine();

                                if (a > b)
                                {
                                    Console.WriteLine("a er det største tal");
                                    Console.WriteLine();
                                }
                                else if (b > a)
                                {
                                    Console.WriteLine("b er det største tal");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("a og b er lige store");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ugyldigt input for b. Prøv igen.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt input for a. Prøv igen.");
                        }
                    }
                }
            }
        }
    