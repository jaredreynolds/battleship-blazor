using System.Collections.Generic;

namespace Battleship
{
    public class Salvo
    {
        private Player Opponent;
        private List<Coordinate> Shots;
        public Salvo(Player opponent, List<Coordinate> shots)
        {
            Opponent = opponent;
            Shots = shots;
        }

        public List<Coordinate> Results(){
            List<Coordinate> hits = new List<Coordinate>();
            foreach (var coordinate in Shots)
            {
                foreach (Ship ship in Opponent.Fleet.Ships)
                {
                    foreach(Coordinate cor in ship.Position){
                        if(cor == coordinate){
                            ship.ShipDamage = new bool[ship.ShipDamage.Length-1];
                            hits.Add(cor);
                        }
                    }
                }
            }
            return hits;
        }
    }
}