using System;
using System.Collections.Generic;
using System.Text;


namespace Tippekuppong12
{
    class TwelveMatches
    {
        string betsText;
        string[] bets;
        Match[] matches = new Match[12];
        int correctCount = 0;
        bool gameFinished = false;
        string command = "";
        public TwelveMatches()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            betsText = Console.ReadLine();
            SplitStrings(betsText);


            
        }

        private void SplitStrings(string betsText)
        {
            bets = betsText.Split(",");
            for (var i = 0; i < 12; i++)
            {
                matches[i] = new Match(bets[i]);
            }
        }

        private void SelectAndScoreMatch()
        {
            while (!gameFinished)
            {
                helpText(0, 0);
                command = Console.ReadLine();
                if (command == "X") break;
                PlayGame();
            }
        }

        private void PlayGame()
        {
            var matchNo = Convert.ToInt32(command);
            var team = Console.ReadLine();
            var selectedMatch = matches[matchNo - 1];
            int matchCount = 0;
            selectedMatch.AddGoal(team == "H");
            for (var index = 0; index < matches.Length; index++)
            {
                var match = matches[index];
                var matchNoI = index + 1;
                var isBetCorrect = match.CheckResult();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                if (isBetCorrect) IncreaseScore();
                Console.WriteLine($"Kamp {matchNo}: {match.Result} - {isBetCorrectText}");
                matchCount++;
            }

            if (matchCount >= 11) PrintNumberCorrect();
        }

        private int IncreaseScore()
        {
            return correctCount++;
        }

        private void PrintNumberCorrect()
        {
            Console.WriteLine($"Du har {this.correctCount} rette.");
        }

        private static void helpText(int version, int matchNo)
        {
            
            if (version == 1) Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
            else if (version == 0) Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
        }
    }
}
