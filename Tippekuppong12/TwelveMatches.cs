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
                CountCorrect(matches[i]);
            }
        }

        private void CountCorrect(Match m)
        {
            if (m.Result == "riktig") correctCount++;
            else { // Vi har gjort ferdig Bet, og nå lager vi while loopen som sjekker result opp mot Bet.
                // Undersøk Match funksjonen fra forrige oppg.
            }
        }

    }
}
