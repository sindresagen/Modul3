using System;
using System.Collections.Generic;
using System.Text;

namespace TolvKamper2
{
    class TolvKamper
    {
        string betsText;
        string[] bets;
        Match[] matches = new Match[12];
        int correctCount;
        public bool gameFinished;
        public TolvKamper()
        {
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
                    if (i == 11)
                    {
                        gameFinished = true;
                        PrintNumberCorrect();
                        break;
                    }
                    matches[i] = new Match(bets[i]);
                    PlayGame(matches[i], i);
                }
            }
        }


        public void PlayGame(Match singleMatch, int i)
        {

            if (!gameFinished)
            {
                var matchNo = i + 1;
                Console.WriteLine($"Du scorer for {matchNo}");
                Console.WriteLine("Skriv inn H, B eller U");
                var command = Console.ReadLine();
                var selectedMatch = singleMatch;
                selectedMatch.HandleCommand(command == "H" || command == "B"));
                if (selectedMatch.IsBetCorrect())
                {
                    correctCount++;
                }
                if (command == "X")
                {
                    gameFinished = true;
                    Console.WriteLine($"Du fikk {correctCount} riktige!");
                }
            }
        }


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
