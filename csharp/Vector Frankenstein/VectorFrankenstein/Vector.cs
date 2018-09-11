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
            return x;
        }

        public int Y()
        {
            return y;
        }

        public Vector Add(Vector vector)
        {
            var sumOfX = X() + vector.X();
            var sumOfY = Y() + vector.Y();

            return new Vector(sumOfX, sumOfY);
        }

        public Vector Subtract(Vector vector)
        {
            var differenceInX = X() - vector.X();
            var differenceInY = Y() - vector.Y();

            return new Vector(differenceInX, differenceInY);
        }

        public Vector MultiplyBy(int multiplier)
        {
            return new Vector(X() * multiplier, Y() * multiplier);
        }

        public int DotProductWith(Vector anotherVector)
        {
            var xMultiplied = X() * anotherVector.X();
            var yMultiplied = Y() * anotherVector.Y();

            return xMultiplied + yMultiplied;
        }

        public int SumOfSquares()
        {
            return DotProductWith(this);
        }

        public double Magnitude()
        {
            return Math.Sqrt(SumOfSquares());
        }

        public double DistanceFrom(Vector anotherVector)
        {
            return Subtract(anotherVector).Magnitude();
        }

        public int SquaredDistanceFrom(Vector anotherVector)
        {
            return Subtract(anotherVector).SumOfSquares();
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

            return X() == other.X()
                   && Y() == other.Y();
        }
    }
}
