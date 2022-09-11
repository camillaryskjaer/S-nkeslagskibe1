using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sænkeslagskibe1
{
    internal class PlayerTwo
    {
        // Your playerboard
        public string[,] playerboard = new string[11, 11]
        {
        {"[ ]","[A]","[B]", "[C]", "[D]", "[E]", "[F]", "[G]", "[H]", "[I]", "[J]"},
        {"[1]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[2]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[3]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[4]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[5]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[6]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[7]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[8]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[9]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[10]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]","[ ]", "[ ]", "[ ]"}
        };

        // Enemy playerboard
        public string[,] enemyboard = new string[11, 11]
        {
        {"[ ]","[A]","[B]", "[C]", "[D]", "[E]", "[F]", "[G]", "[H]", "[I]", "[J]"},
        {"[1]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[2]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[3]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[4]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[5]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[6]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[7]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[8]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[9]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[10]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]","[ ]", "[ ]", "[ ]"}
        };

        // instances and valueables
        private List<Ship> ships = new List<Ship>();
        private Ship hangar = new HangarShip();
        private Ship battleship = new BattleShip();
        private Ship destroyer = new Destroyer();
        private Ship uboat = new Uboat();
        private Ship patrol = new PatrolBoat();
        private PlayerOne player = new PlayerOne();
        protected internal int playerLife;

        private Random random = new Random();


        // Places ships in list
        private void ShipIntoList()
        {
            ships.Add(hangar);
            ships.Add(battleship);
            ships.Add(destroyer);
            ships.Add(uboat);
            ships.Add(patrol);

        }


        // Places ships on board
        private void PlaceShips()
        {
            Random random = new Random();

            int x = random.Next(1, 10);
            int y = random.Next(1, 10);

            bool found = true;

            while (found)
            {
                for (int i = 0; i < playerboard.Length; i++)
                {
                    if (playerboard[i, y] == "[ ]")
                    {
                        playerboard[i, y] = "X";
                    }
                }

            }

        }

        // Player shooting
        public string Shooting(int x, int y)
        {
            if (player.playerboard[x, y] == "X")
            {
                playerLife--;

                return $"You hit";
            }
            else
            {
                return $"You missed";
            }


        }


    }
}
