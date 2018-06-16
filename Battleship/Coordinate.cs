using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Coordinate : IEquatable<Coordinate>
    {
        public int xAxis;
        public int yAxis;

        public Coordinate(int x, int y){
            xAxis = x;
            yAxis = y;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Coordinate);
        }

        public bool Equals(Coordinate other)
        {
            return other != null &&
                   xAxis == other.xAxis &&
                   yAxis == other.yAxis;
        }

        public override int GetHashCode()
        {
            var hashCode = -819627801;
            hashCode = hashCode * -1521134295 + xAxis.GetHashCode();
            hashCode = hashCode * -1521134295 + yAxis.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"({xAxis},{yAxis})";
        }

        public static bool operator ==(Coordinate coordinate1, Coordinate coordinate2)
        {
            return EqualityComparer<Coordinate>.Default.Equals(coordinate1, coordinate2);
        }

        public static bool operator !=(Coordinate coordinate1, Coordinate coordinate2)
        {
            return !(coordinate1 == coordinate2);
        }
    }
}