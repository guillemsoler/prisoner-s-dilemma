using System;
using System.Collections.Generic;
using System.Text;

namespace prisoneers_dilema
{
    public class Player
    {
        public string Name { set; get; }
        public string Resolution { set; get; }
        public int WinsLoses { set; get; }

        public Player(string name, string resolution)
        {
            this.Name = name;
            this.Resolution = resolution;

        }
        public void ChangeResolution(Player player, string resolution)
        {
            player.Resolution = resolution;
        }
    }
}
