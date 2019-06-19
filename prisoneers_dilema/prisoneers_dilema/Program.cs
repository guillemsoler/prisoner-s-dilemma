using System;

namespace prisoneers_dilema
{
    class Program
    {
        static void Main(string[] args)
        {
            Player panfilo = new Player("panfilo", Constants.cooperate);
            Player maquiavelo = new Player("maquiavelo", Constants.desert);
            Player tuntun = new Player("tuntun", SetRandomResolution());

            FrontEnd.numberRound = 1;
            for (int i = 1; i <= 50; i++)
            {
                Logic.SetWinsLoses(maquiavelo, panfilo);
                //FrontEnd.ShowGame(maquiavelo, panfilo);
            }
            FrontEnd.numberRound = 1;
            for (int i = 1; i <= 50; i++)
            {
                Logic.SetWinsLoses(maquiavelo, tuntun);
                //FrontEnd.ShowGame(maquiavelo, tuntun);
            }
            FrontEnd.numberRound = 1;
            for (int i = 1; i <= 50; i++)
            {
                Logic.SetWinsLoses(panfilo, tuntun);
                //FrontEnd.ShowGame(panfilo, tuntun);
            }
            FrontEnd.ShowRanking(panfilo, maquiavelo, tuntun);
        }
        private static string SetRandomResolution()
        {
            int random;
            string resolution;
            Random rnd = new Random();

            random = rnd.Next(0, 2);

            if(random == 0)
            {
                resolution = Constants.cooperate;
            }
            else
            {
                resolution = Constants.desert;
            }
            return resolution;
        }
    }
}
