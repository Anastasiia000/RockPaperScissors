using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Player
    {
        public string name;
        public VARIANTS VARIANTS;
        private Random rnd = new Random();
        private int variants;

        public Player(VARIANTS variants, string name)
        {
            this.name = name;
            this.VARIANTS = variants;
        }
        public Player()
        {
            variants = rnd.Next(1, 3);
            switch (variants)
            {
                case 1: VARIANTS = VARIANTS.Rock; break;
                case 2: VARIANTS = VARIANTS.Scissors; break;
                case 3: VARIANTS = VARIANTS.Paper; break;
            }

            name = "Bot";            
        }

        public string whoWins(Player player1, Player player2)
        {
            string winner = "Winner is ";
            if (player1.VARIANTS == VARIANTS.Paper && player2.VARIANTS == VARIANTS.Paper)
                winner = "Draw";
            if (player1.VARIANTS == VARIANTS.Rock && player2.VARIANTS == VARIANTS.Rock)
                winner = "Draw";
            if (player1.VARIANTS == VARIANTS.Scissors && player2.VARIANTS == VARIANTS.Scissors)
                winner = "Draw";
            if (player1.VARIANTS == VARIANTS.Rock && player2.VARIANTS == VARIANTS.Paper)
                winner += (string)player2.name;
            if (player1.VARIANTS == VARIANTS.Paper && player2.VARIANTS == VARIANTS.Rock)
                winner += (string)player1.name;
            if (player1.VARIANTS == VARIANTS.Paper && player2.VARIANTS == VARIANTS.Scissors)
                winner += (string)player2.name;
            if (player1.VARIANTS == VARIANTS.Scissors && player2.VARIANTS == VARIANTS.Paper)
                winner += (string)player1.name;
            if (player1.VARIANTS == VARIANTS.Rock && player2.VARIANTS == VARIANTS.Scissors)
                winner += (string)player1.name;
            if (player1.VARIANTS == VARIANTS.Scissors && player2.VARIANTS == VARIANTS.Rock)
                winner += (string)player2.name;
            return winner;
        }

    }
}
