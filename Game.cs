using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class Game
    {
        public string team1 { get; set; }
        public string team2 { get; set; }
        public int team1_score { get; set; }
        public int team2_score { get; set; }  // format: team1(team1 score) - team2 (team2 score)

        public Game(){ }

        public Game( string team1, int team1_score, string team2, int team2_score)
        {
            this.team1 = team1;
            this.team1_score = team1_score;
            this.team2 = team2;
            this.team2_score = team2_score;
        }

        public override string ToString()
        {

            return String.Format("{0} ({1}) - {2} ({3})", team1, team1_score, team2, team2_score);

        }
    }
}
