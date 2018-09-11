using System;

namespace VectorFrankenstein
{
    public class Vector : IEquatable<Vector>
    {
        private readonly int x;
        private readonly int y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X()
        {
            return this.x;
        }

        public int Y()
        {
            return this.y;
        }

        public Vector add(Vector vector)
        {
            int sumOfX = X() + vector.X();
            int sumOfY = Y() + vector.Y();

            return new Vector(sumOfX, sumOfY);
        }

        public Vector subtract(Vector vector)
        {
            int differenceInX = X() - vector.X();
            int differenceInY = Y() - vector.Y();

            return new Vector(differenceInX, differenceInY);
        }

        public Vector multiplyBy(int multiplier)
        {
            return new Vector(X() * multiplier, Y() * multiplier);
        }

        public int dotProductWith(Vector anotherVector)
        {
            int xMultiplied = X() * anotherVector.X();
            int yMultiplied = Y() * anotherVector.Y();

            return xMultiplied + yMultiplied;
        }

        public int sumOfSquares()
        {
            return dotProductWith(this);
        }

        public double magnitude()
        {
            return Math.Sqrt(sumOfSquares());
        }

        public double distanceFrom(Vector anotherVector)
        {
            return subtract(anotherVector).magnitude();
        }

        public int squaredDistanceFrom(Vector anotherVector)
        {
            return subtract(anotherVector).sumOfSquares();
        }

        public bool Equals(Vector other)
        {
            if (this == other)
            {
                return true;
            }

            if (other == null)
            {
                return false;
            }

            return this.X() == other.X()
                   && this.Y() == other.Y();
        }
    }
}
