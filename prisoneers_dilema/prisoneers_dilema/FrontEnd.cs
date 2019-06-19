using System;
using System.Collections.Generic;
using System.Text;

namespace prisoneers_dilema
{
    public class FrontEnd
    {
        public static int numberRound;
        public static void ShowGame(Player player1, Player player2)
        {
            Console.WriteLine(Constants.round + numberRound);
            Console.WriteLine(player1.Name + Constants.balance + player1.WinsLoses);
            Console.WriteLine(player2.Name + Constants.balance + player2.WinsLoses);
            numberRound++;
        }
        public static void ShowRanking(Player player1, Player player2, Player player3)
        {
            //Console.Clear();
            Console.WriteLine(Constants.ranking);
            if (player1.WinsLoses > player2.WinsLoses && player1.WinsLoses > player3.WinsLoses)
            {
                Console.WriteLine(player1.Name + Constants.balance + player1.WinsLoses);
                if(player2.WinsLoses > player3.WinsLoses)
                {
                    Console.WriteLine(player2.Name + Constants.balance + player2.WinsLoses);
                    Console.WriteLine(player3.Name + Constants.balance + player3.WinsLoses);
                }
                else
                {
                    Console.WriteLine(player2.Name + Constants.balance + player2.WinsLoses);
                    Console.WriteLine(player3.Name + Constants.balance + player3.WinsLoses);
                }
            }
            else if(player2.WinsLoses > player1.WinsLoses && player2.WinsLoses > player3.WinsLoses)
            {
                Console.WriteLine(player2.Name + Constants.balance + player2.WinsLoses);
                if (player1.WinsLoses > player3.WinsLoses)
                {
                    Console.WriteLine(player1.Name + Constants.balance + player1.WinsLoses);
                    Console.WriteLine(player3.Name + Constants.balance + player3.WinsLoses);
                }
                else
                {
                    Console.WriteLine(player3.Name + Constants.balance + player3.WinsLoses);
                    Console.WriteLine(player1.Name + Constants.balance + player1.WinsLoses);
                }
            }
            else
            {
                Console.WriteLine(player3.Name + Constants.balance + player3.WinsLoses);
                if (player1.WinsLoses > player2.WinsLoses)
                {
                    Console.WriteLine(player1.Name + Constants.balance + player1.WinsLoses);
                    Console.WriteLine(player2.Name + Constants.balance + player2.WinsLoses);
                }
                else
                {
                    Console.WriteLine(player2.Name + Constants.balance + player2.WinsLoses);
                    Console.WriteLine(player1.Name + Constants.balance + player1.WinsLoses);
                }
            }
        }
    }
}
