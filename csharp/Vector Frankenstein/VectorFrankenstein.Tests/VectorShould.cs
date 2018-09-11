using NUnit.Framework;

namespace VectorFrankenstein.Tests
{
    [TestFixture]
    internal class VectorShould
    {

        [Test]
        public void Add_Itself_To_Another_Vector()
        {
            var vectorA = new Vector(1, 2);
            var vectorB = new Vector(2, 1);


            var added = vectorA.Add(vectorB);


            Assert.That(added, Is.EqualTo(new Vector(3, 3)));
        }

        [Test]
        public void Subtract_Itself_From_Another_Vector()
        {
            var vectorA = new Vector(5, 4);
            var vectorB = new Vector(3, 10);


            var subtracted = vectorA.Subtract(vectorB);


            Assert.That(subtracted, Is.EqualTo(new Vector(2, -6)));
        }
        [Test]
        public void Multiply_Vector_By_Scalar()
        {
            var vector = new Vector(1, 2);


            var vectorMultiplied = vector.MultiplyBy(2);


            Assert.That(vectorMultiplied, Is.EqualTo(new Vector(2, 4)));
        }

        [Test]
        public void Calculate_Dot_Product_Of_Itself_And_Another_Vector()
        {
            var vector = new Vector(1, 2);
            var anotherVector = new Vector(8, 2);


            var dotProduct = vector.DotProductWith(anotherVector);


            Assert.That(dotProduct, Is.EqualTo(12));
        }

        [Test]
        public void Calculate_Sum_Of_Squares()
        {
            var vector = new Vector(1, 2);


            var sum = vector.SumOfSquares();


            Assert.That(sum, Is.EqualTo(5));
        }

        [Test]
        public void Calculate_Magnitude()
        {
            var vector = new Vector(4, 3);


            var magnitude = vector.Magnitude();


            Assert.That(magnitude, Is.EqualTo(5.0));
        }

        [Test]
        public void Calculate_Squared_Distance_Between_Itself_And_Another_Vector()
        {
            var vector = new Vector(6, 8);
            var anotherVector = new Vector(2, 6);


            var squaredDistance = vector.SquaredDistanceFrom(anotherVector);


            Assert.That(squaredDistance, Is.EqualTo(20));
        }

        [Test]
        public void Calculate_Distance_Between_Itself_And_Another_Vector()
        {
            var vector = new Vector(5, 8);
            var anotherVector = new Vector(2, 4);


            var distance = vector.DistanceFrom(anotherVector);


            Assert.That(distance, Is.EqualTo(5.0));
        }
    }
}
