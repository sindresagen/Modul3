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
        public bool gameFinished = false;
        string command = "";
        public TwelveMatches()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            betsText = Console.ReadLine();
            SplitStrings(betsText);


            
        }

        private void SplitStrings(string betsText)
        {
            if (!gameFinished)
            {
                helpText(0, 0);
                bets = betsText.Split(",");
                for (var i = 0; i < 12; i++)
                {
                    matches[i] = new Match(bets[i]);
                    PlayGame(matches[i], i);
                }
            }
            else
            {
                PrintNumberCorrect();
            }
            

        }

        private void SelectAndScoreMatch()
        {
            
        }

        public void PlayGame(Match singleMatch, int i)
        {
            // vi holder på her, må vise frem hva man skal gjøre hver gang. eks 1-12 og hvilken Scoring
            if (!gameFinished)
            {
                var matchNo = i+1;
                System.Console.WriteLine($"Du scorer for {matchNo}");
                System.Console.WriteLine("Skriv inn H, B eller U");
                var team = Console.ReadLine();
                var selectedMatch = singleMatch;
                selectedMatch.AddGoal(team == "H");
                if (selectedMatch.IsBetCorrect(team))
                {
                    correctCount++;
                }
                if (team == "X")
                {
                    gameFinished = true;
                    System.Console.WriteLine($"Du fikk {correctCount} riktige!");
                    return;
                }
            }
        }

        //private int IncreaseScore()
        //{
        //    return correctCount++;
        //}

        private void PrintNumberCorrect()
        {
            Console.WriteLine($"Du har {correctCount} rette.");
        }

        private static void helpText(int version, int matchNo)
        {
            
            if (version == 1) Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
            else if (version == 0) Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
        }
    }
}
