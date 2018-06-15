using System.Collections.Generic;

namespace Battleship
{
    public class Ship
    {
        private ShipClass _shipClass;

        public Ship(ShipClass shipClass, Direction dir, Coordinate startingLocation){
            _shipClass = shipClass;
            ShipDamage = new bool[ShipClassSize.ShipSize[shipClass]];
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
        }

        public ShipClass ShipClass {
            get { return _shipClass; }
            set { _shipClass = value; }
        }   

        public ShipLocation Position {get; set;}

        public bool[] ShipDamage;
    }

    public struct ShipLocation
    {
        public List<Coordinate> Coordinates;
        public Direction Orientation;
    }

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}