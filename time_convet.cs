// See https://aka.ms/new-console-template for more information
using Spectre.Console;

namespace SpectreTimer
{
    internal class TimerConvert
    {
        internal static TimeSpan[] ConvetInputToTime(double time, double rest)
        {
            var timelist = new TimeSpan[2];

            TimeSpan t = TimeSpan.FromMinutes(time);
            TimeSpan r = TimeSpan.FromMinutes(rest);
            timelist[0] = t;
            timelist[1] = r;
            return timelist;
        }

        internal static void DisplayTime(TimeSpan[] time)
        {
            var layout = new Layout("Root")
                            .SplitColumns(
                                new Layout("progress"),
                                new Layout("Rigth")
                                    .SplitRows(
                                        new Layout("name"),
                                        new Layout("Timer"),
                                        new Layout("message")));

            AnsiConsole.Progress()
                .Start(ctx =>
                {
                    // Define tasks
                    var task1 = ctx.AddTask("[green]Work[/]");
                    var task2 = ctx.AddTask("[green]Rest[/]");
                    double progressrate = 100 / time[0].TotalSeconds;
                    double Restprogressrate = 100 / time[1].TotalSeconds;
                    task1.Value = 1;
                    task2.Value = 0;


                    while (time[0].TotalSeconds > 0)
                    {
                        Console.Clear();

                        task1.Increment(progressrate);

                        //AnsiConsole.Markup($"[underline green]{time[0]}[/]");

                        time[0] = time[0].Subtract(TimeSpan.FromSeconds(1));

                        // Create the layout
                        // var layout = new Layout("Root")
                        //     .SplitColumns(
                        //         new Layout("progress"),
                        //         new Layout("Rigth")
                        //             .SplitRows(
                        //                 new Layout("name"),
                        //                 new Layout("Timer"),
                        //                 new Layout("message")));

                        // Update the left column
                        layout["progress"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup($"[underline green]{time[0]}[/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        layout["name"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup(@"[green]
       _                _         _   
 _ _ _|_|___ ___    ___| |___ ___| |_ 
| | | | |_ -| -_|  |  _| | . |  _| '_|
|_____|_|___|___|  |___|_|___|___|_,_|[/]"),
                                    VerticalAlignment.Middle))
                                .Expand());


                        layout["Timer"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup($"[green]{new string('━', (int)(task1.Value / 2))}[/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        layout["message"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup($"[underline green]Keep up, work time![/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        // Render the layout
                        AnsiConsole.Write(layout);

                        Thread.Sleep(1000);
                    }

                    Thread.Sleep(1500);
                    task1.Value = 100;
                    task2.Value = 1;


                    while (time[1].TotalSeconds > 0)
                    {
                        Console.Clear();



                        task2.Increment(progressrate);

                        //AnsiConsole.Markup($"[underline green]{time[0]}[/]");

                        time[1] = time[1].Subtract(TimeSpan.FromSeconds(1));

                        // Create the layout
                        // var layout = new Layout("Root")
                        //     .SplitColumns(
                        //         new Layout("progress"),
                        //         new Layout("Rigth")
                        //             .SplitRows(
                        //                 new Layout("name"),
                        //                 new Layout("Timer"),
                        //                 new Layout("message")));

                        // Update the left column
                        layout["progress"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup($"[underline blue]{time[1]}[/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        layout["name"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup(@"[blue]
       _                _         _   
 _ _ _|_|___ ___    ___| |___ ___| |_ 
| | | | |_ -| -_|  |  _| | . |  _| '_|
|_____|_|___|___|  |___|_|___|___|_,_|[/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        layout["Timer"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup($"[blue]{new string('━', (int)(task2.Value / 2))}[/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        layout["message"].Update(
                            new Panel(
                                Align.Center(
                                    new Markup($"[underline blue]Good job!![/]"),
                                    VerticalAlignment.Middle))
                                .Expand());

                        // Render the layout
                        AnsiConsole.Write(layout);

                        Thread.Sleep(1000);
                    }



                });
        }

    }


}
