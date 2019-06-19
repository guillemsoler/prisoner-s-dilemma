using System;
using System.Collections.Generic;
using System.Text;

namespace prisoneers_dilema
{
    public class Logic
    {
        public static void SetWinsLoses(Player player1, Player player2)
        {
            if(player1.Resolution == Constants.cooperate && player2.Resolution == Constants.desert)
            {
                player1.WinsLoses -= Constants.cooperateDesert;
                player2.WinsLoses += Constants.cooperateDesert;
            }
            else if (player1.Resolution == Constants.cooperate && player2.Resolution == Constants.cooperate)
            {
                player1.WinsLoses += Constants.cooperateCooperate;
                player2.WinsLoses += Constants.cooperateCooperate;
            }
            else if (player1.Resolution == Constants.desert && player2.Resolution == Constants.desert)
            {
                player1.WinsLoses -= Constants.desertDesert;
                player2.WinsLoses -= Constants.desertDesert;
            }
            else
            {
                player1.WinsLoses += Constants.cooperateDesert;
                player2.WinsLoses -= Constants.cooperateDesert;
            }

        }
    }
}
