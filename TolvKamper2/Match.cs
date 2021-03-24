using System;
using System.Collections.Generic;
using System.Text;

namespace TolvKamper2
{
    class Match
    {
        public int HomeGoals;
        public int AwayGoals;
        public bool MatchIsRunning = true;
        public string Bet;

        public Match(string bet)
        {
            bet = bet.ToUpper();
            Bet = bet;
        }

        public void HandleCommand(string command)
        {
            if (command == "X") MatchIsRunning = false;
            else if (command == "H") HomeGoals++;
            else if (command == "B") AwayGoals++;
        }

        public string CheckResult()
        {
            return HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        }

        public string GetScore()
        {
            return $"Stillingen er {HomeGoals}-{AwayGoals}";
        }

        public bool IsBetCorrect()
        {
            return Bet == CheckResult();
        }
    }
}
