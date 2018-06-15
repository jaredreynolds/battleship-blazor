using System.Collections.Generic;

namespace Battleship
{
    public class Ship
    {
        private ShipClass _shipClass;

        public Ship(ShipClass shipClass, Direction dir, Coordinate startingLocation){
            _shipClass = shipClass;
            ShipDamage = new bool[ShipClassSize.ShipSize[shipClass]];
            #region coordinate stuff
            // Position.Coordinates.Add(startingLocation);
            // Coordinate modifiedLocation = startingLocation;
            // if(dir == Direction.North){
            //     //Modify the x coordinate
            //     for(int i = 1; i < ShipClassSize.ShipSize[shipClass]; i++){
            //         modifiedLocation.yAxis = modifiedLocation.yAxis--; 
            //         Position.Coordinates.Add(modifiedLocation);
            //     }
            // }
            // if (dir == Direction.South)
            // {
            //     //Modify the x coordinate
            //     for (int i = 1; i < ShipClassSize.ShipSize[shipClass]; i++)
            //     {
            //         modifiedLocation.yAxis = modifiedLocation.yAxis++;
            //         Position.Coordinates.Add(modifiedLocation);
            //     }
            // }
            // if(dir == Direction.East){
            //     // Modify the y coordinate
            //     for (int i = 1; i < ShipClassSize.ShipSize[shipClass]; i++)
            //     {
            //         modifiedLocation.yAxis = modifiedLocation.xAxis--;
            //         Position.Coordinates.Add(modifiedLocation);
            //     }
            // }
            // if (dir == Direction.West)
            // {
            //     // Modify the y coordinate
            //     for (int i = 1; i < ShipClassSize.ShipSize[shipClass]; i++)
            //     {
            //         modifiedLocation.yAxis = modifiedLocation.xAxis++;
            //         Position.Coordinates.Add(modifiedLocation);
            //     }
            // }
            #endregion
        }

        public ShipClass ShipClass {
            get { return _shipClass; }
            set { _shipClass = value; }
        }   

        public List<Coordinate> Position {get; }

        public bool[] ShipDamage;

        public void DeployShip (Coordinate sternCoordinate, Direction orientation)
        {
            var xIncrement = 0;
            var yIncrement = 0;
            switch (orientation)
            {
                case Direction.East:
                    xIncrement = 1;
                    yIncrement = 0;
                    break;
                case Direction.North:
                    xIncrement = 0;
                    yIncrement = 1;
                    break;
                case Direction.South:
                    xIncrement = 0;
                    yIncrement = -1;
                    break;
                case Direction.West:
                    xIncrement = -1;
                    yIncrement = 0;
                    break;
            }
            var currentCoordinate = sternCoordinate;

            for (var shipCell = 0; shipCell < ShipClassSize.ShipSize[_shipClass]; shipCell++)
            {
                currentCoordinate = new Coordinate(sternCoordinate.xAxis + xIncrement, sternCoordinate.yAxis + yIncrement);
                Position.Add(currentCoordinate);
            }
        }
    }

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}