// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using Spectre.Console;

namespace SpectreTimer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //validate args to start aplication
            if (args.Length > 0 &&
                args.Length <= 2 &&
                double.TryParse(Regex.Replace(args[0], "[,:.]", "."), out double time) &&
                double.TryParse(Regex.Replace(args[1], "[,:.]", "."), out double rest))
            {
                TimerConvert.DisplayTime(TimerConvert.ConvetInputToTime(time, rest));
            }

            // alt way to start aplication if no args
            SelectionMenu.Menu();


        }
    }
}