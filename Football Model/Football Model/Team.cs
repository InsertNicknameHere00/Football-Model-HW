using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Model
{
    class Team
    {
        public Coach Coach { get; set; }
        public Footballplayer[] Players { get; set; }

        public int AverageAge
        {
            get
            {
                int totalAge = 0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }
                return totalAge / Players.Length;
            }
        }

    }
}