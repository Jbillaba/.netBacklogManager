using Spectre.Console;

class Program
{
    public static List<string> MenuChoices = new() {"Add Title", "Exit"};
    public static List<Game> games = new();

    public class Game
    {
        public string Title {get;}
        public int HoursToBeat {get;}

        public Game(string title, int hourstobeat)
        {
            Title = title;
            HoursToBeat = hourstobeat;
        }
    }

    public static void SeeTitles()
    {
        AnsiConsole.Clear();
        
    }

    public static void AddTitle()
    {
        AnsiConsole.Clear();
        var gameTitle = AnsiConsole.Ask<string>("what is the name of the game");
        var howLongToBeat = AnsiConsole.Ask<int>("how many hours to beat");
        games.Add(new Game(gameTitle,howLongToBeat ));
    }

    public static void MenuChoice(string choice)
    {
        switch(choice)
        {
            case "Add Title":
                AddTitle();
                break;
            case "Exit":
                var answer = AnsiConsole.Confirm("would you like to exit the program?", false);
                if (answer == true) {Environment.Exit(1);}
                break;
        }
    }

    public static void Menu()
    {
        AnsiConsole.Clear();
        var menuChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select What You Would Like To Do")
            .AddChoices(MenuChoices)
        );
        MenuChoice(menuChoice);
    }
}