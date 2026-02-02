namespace TennisTDDKata
{
    using System;

    public class Tennis
    {
        public string GetScore(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore == 0 && playerTwoScore == 0)
            {
                return "Love-All";
            }else if (playerOneScore == 1 && playerTwoScore == 0)
            {
                return "Fifteen-Love";
            }

            return "Score not implemented yet";
        }
    }
}
