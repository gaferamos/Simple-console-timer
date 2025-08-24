using Spectre.Console;
namespace SpectreTimer
{
    public class SelectionMenu
    {
        internal static void Menu()
        {
            // give user options to run or exit dthe aplication
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Ready for work?")
                    .PageSize(10)
                    .AddChoices(new[] { "Initiate timer", "Quit", }));

            switch (option)
            {
                case "Quit":

                    System.Environment.Exit(0);

                    break;

                case "Initiate timer":

                    double workTime;
                    double restTime;

                    workTime = AnsiConsole.Prompt(
                        new TextPrompt<double>("[green]How many minutes are we focusing on working?[/]"));

                    restTime = AnsiConsole.Prompt(
                        new TextPrompt<double>("[blue]What about our rest time, how many minutes?[/]"));
                    TimerConvert.DisplayTime(TimerConvert.ConvetInputToTime(workTime, restTime));

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