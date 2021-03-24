using System;
using System.Collections.Generic;
using System.Text;

namespace Tippekupong1kamp
{
    class Match
    {
        private int HomeGoals = 0;
        private int AwayGoals = 0;
        private bool MatchIsRunning = true;
        private string _command;
        private string bet;

        public Match()
        {
            bet = Console.ReadLine();
            Play();
        }

        private void Play()
        {
            while (MatchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                _command = Console.ReadLine();
                if (_command == "X") MatchIsRunning = false;
                else if (_command == "H") HomeGoals++;
                else if (_command == "B") AwayGoals++;
                Console.WriteLine($"Stillingen er {HomeGoals}-{AwayGoals}");
            }

            CheckResult();
        }

        private void CheckResult()
        {
            string result = "";
            if (HomeGoals == AwayGoals) result = "U";
            else if (HomeGoals > AwayGoals) result = "H";
            else result = "B";
            isBetCorrect(result);
        }

        private void isBetCorrect(string result)
        {
            string isBetCorrect = bet.Contains(result) ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrect}");
        }
    }
}
