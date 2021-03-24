using System;
using System.Collections.Generic;
using System.Text;

namespace Tippekuppong12
{
    class Match
    {
        private int HomeGoals = 0;
        private int AwayGoals = 0;
        private bool MatchIsRunning = true;
        private string _command;
        private string bet;
        public string Result;

        public Match(string betx)
        {
            betx = betx.ToUpper();
            bet = betx;
        }

        private void Play()
        {
            while (MatchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                _command = Console.ReadLine();
                if (_command == "X") MatchIsRunning = false;
                else if (_command == "H") AddGoal(_command == "H");
                else if (_command == "B") AddGoal(_command == "H");
                System.Console.WriteLine($"Stillingen er {HomeGoals}-{AwayGoals}");
            }

            CheckResult();
        }

        public void AddGoal(bool v)
        {
            if (v) HomeGoals++;
            else AwayGoals++;

        }

        public bool CheckResult()
        {
            string result = "";
            if (HomeGoals == AwayGoals) result = "U";
            else if (HomeGoals > AwayGoals) result = "H";
            else result = "B";
            Result = result;
            return IsBetCorrect(result);
        }

        public bool IsBetCorrect(string result)
        {
            string isBetCorrect = bet.Contains(result) ? "riktig" : "feil";
            Result = isBetCorrect;
            return isBetCorrect == "riktig";
        }
    }
}
