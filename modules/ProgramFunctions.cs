using Spectre.Console;

class Program
{
    public static List<string> MenuChoices = new() {"Add Title", "Exit"};

    public static void Menu()
    {
        AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select What You Would Like To Do")
            .AddChoices(MenuChoices)
        );
    }
}