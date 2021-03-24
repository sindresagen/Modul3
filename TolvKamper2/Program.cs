using System;

namespace TolvKamper2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Match KampEn = new Match();
            TolvKamper tolvKamper = new TolvKamper();
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var match = new Match(bet);
            while (match.MatchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                match.HandleCommand(command);
                Console.WriteLine(match.GetScore());
            }

            var isBetCorrectText = match.IsBetCorrect() ? "Du tippet riktig!" : "Du tippet feil!";
            Console.WriteLine();
        }
    }
}
