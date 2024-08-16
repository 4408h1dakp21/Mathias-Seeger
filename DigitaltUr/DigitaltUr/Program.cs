using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string previousTime = ""; // Initialize the variable to store the previous time.

        while (true)
        {
            string currentTime = DateTime.Now.ToLongTimeString(); // Get the current time in HH:mm:ss format.

            // Check if the current time is different from the previous time.
            if (previousTime != currentTime)
            {
                // Loop through each character in the current time string.
                for (int i = 0; i < currentTime.Length; i++)
                {
                    // If the character has changed or this is the first run, redraw that digit.
                    if (previousTime == "" || currentTime[i] != previousTime[i])
                    {
                        // Position the cursor for the current digit or colon.
                        Console.SetCursorPosition(i * 6, 0);
                        DisplayDigit(currentTime[i]); // Display the appropriate digit or colon.
                    }
                }

                previousTime = currentTime; // Update previousTime to the current time.
            }

            Thread.Sleep(1000); // Wait for 1 second before updating the time again.
        }
    }

    // Method to display a digit or colon based on the character passed.
    static void DisplayDigit(char c)
    {
        string[] displayLines;

        // Use a switch statement to select the appropriate pattern based on the character.
        switch (c)
        {
            case '0':
                displayLines = new string[]
                {
                    " ███ ",
                    "█   █",
                    "█   █",
                    "█   █",
                    "█   █",
                    "█   █",
                    " ███ "
                };
                break;
            case '1':
                displayLines = new string[]
                {
                    "  █  ",
                    " ██  ",
                    "  █  ",
                    "  █  ",
                    "  █  ",
                    "  █  ",
                    "█████"
                };
                break;
            case '2':
                displayLines = new string[]
                {
                    " ███ ",
                    "█   █",
                    "    █",
                    "  ██ ",
                    " █   ",
                    "█    ",
                    "█████"
                };
                break;
            case '3':
                displayLines = new string[]
                {
                    " ███ ",
                    "█   █",
                    "    █",
                    "  ██ ",
                    "    █",
                    "█   █",
                    " ███ "
                };
                break;
            case '4':
                displayLines = new string[]
                {
                    "   █ ",
                    "  ██ ",
                    " █ █ ",
                    "█  █ ",
                    "█████",
                    "   █ ",
                    "   █ "
                };
                break;
            case '5':
                displayLines = new string[]
                {
                    "█████",
                    "█    ",
                    "████ ",
                    "    █",
                    "    █",
                    "█   █",
                    " ███ "
                };
                break;
            case '6':
                displayLines = new string[]
                {
                    " ███ ",
                    "█    ",
                    "█    ",
                    "████ ",
                    "█   █",
                    "█   █",
                    " ███ "
                };
                break;
            case '7':
                displayLines = new string[]
                {
                    "█████",
                    "    █",
                    "   █ ",
                    "  █  ",
                    " █   ",
                    "█    ",
                    "█    "
                };
                break;
            case '8':
                displayLines = new string[]
                {
                    " ███ ",
                    "█   █",
                    "█   █",
                    " ███ ",
                    "█   █",
                    "█   █",
                    " ███ "
                };
                break;
            case '9':
                displayLines = new string[]
                {
                    " ███ ",
                    "█   █",
                    "█   █",
                    " ████",
                    "    █",
                    "   █ ",
                    " ██  "
                };
                break;
            case ':':
                displayLines = new string[]
                {
                    "     ",
                    "     ",
                    "  █  ",
                    "     ",
                    "  █  ",
                    "     ",
                    "     "
                };
                break;
            default:
                displayLines = new string[]
                {
                    "     ",
                    "     ",
                    "     ",
                    "     ",
                    "     ",
                    "     ",
                    "     "
                };
                break;
        }

        // Output each line of the character's pattern to the console.
        for (int j = 0; j < displayLines.Length; j++)
        {
            Console.CursorVisible = false; // Makes cursor invisible and pleasing.
            Console.SetCursorPosition(Console.CursorLeft, j); // Set the cursor for each line.
            Console.Write(displayLines[j]); // Write the line to the console.
            Console.SetCursorPosition(Console.CursorLeft - displayLines[j].Length, Console.CursorTop + 1); // Move cursor back to the start of the next line
        }
    }
}