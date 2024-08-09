using HF1;

Console.CursorVisible = false;

Menu menu = new();
menu.menuOptions = CreateMenuOptions();
menu.Draw();

bool keepRunning = true;
while(keepRunning)
{
    ConsoleKeyInfo key = Console.ReadKey(true);

    switch(key.Key)
    {
        case ConsoleKey.Enter:
            menu.menuOptions[menu.menuIndex].Action();
            menu.Draw();
            break;
        case ConsoleKey.DownArrow:
            menu.UpdateIndex(menu.menuIndex + 1);
            break;
        case ConsoleKey.UpArrow:
            menu.UpdateIndex(menu.menuIndex - 1);
            break;
        default:
            break;
    }
}

static List<Menu.MenuOption> CreateMenuOptions()
{
    return
    [
        new ("Exit", () => { Environment.Exit(0); }),
        new ("Celcius Omregner", CelciusOmregner.Run),
        new ("Valuta Omregner", ValutaOmregner.Run),
        new ("Rumfanget", RumfangBeregner.Run),
        new ("Terningkast", Terningkast.Run),
        new ("Pythagoras", Pythagoras.Run),
        new ("Alder", Alder.Run),
        new ("Gæt et tal", Gaetettal.Run),
        //new ("Porto", Porto.Run),
        //new ("Morse", Morse.Run),
        //new ("Løkker", Loops.Run),
        //new ("Array 1", Array.Run),
        //new ("Arrays", Arrays.Run),
        //new ("Arrays og bubblesort", Bubblesort.Run)
    ];
}