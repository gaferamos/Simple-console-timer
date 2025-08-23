using Spectre.Console;
namespace SpectreTimer
{
    public class SelectionMenu
    {
        internal static void Menu()
        {
            // Ask for the user's favorite fruit
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Ready for work?")
                    .PageSize(2)
                    .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                    .AddChoices(new[] { "Initiate timer", "Quit", }));

            switch (option)
            {
                case "Quit":
                    System.Environment.Exit(0);
                    break;
                case "Initiate timer":
                    double workTime;
                    double restTime;

                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("an error courred");
                    break;


            }

            // Echo the fruit back to the terminal
            AnsiConsole.WriteLine($"I agree. {option} is tasty!");


        }
    }

}