using NUnit.Framework;

namespace VectorFrankenstein.Tests
{
    [TestFixture]
    internal class VectorShould
    {

        [Test]
        public void add_itself_to_another_vector()
        {
            Vector vectorA = new Vector(1, 2);
            Vector vectorB = new Vector(2, 1);


            Vector added = vectorA.add(vectorB);


            Assert.That(added, Is.EqualTo(new Vector(3, 3)));
        }

        [Test]
        public void subtract_itself_from_another_vector()
        {
            Vector vectorA = new Vector(5, 4);
            Vector vectorB = new Vector(3, 10);


            Vector subtracted = vectorA.subtract(vectorB);


            Assert.That(subtracted, Is.EqualTo(new Vector(2, -6)));
        }
        [Test]
        public void multiply_vector_by_scalar()
        {
            Vector vector = new Vector(1, 2);


            Vector vectorMultiplied = vector.multiplyBy(2);


            Assert.That(vectorMultiplied, Is.EqualTo(new Vector(2, 4)));
        }

        [Test]
        public void calculate_dot_product_of_itself_and_another_vector()
        {
            Vector vector = new Vector(1, 2);
            Vector anotherVector = new Vector(8, 2);


            int dotProduct = vector.dotProductWith(anotherVector);


            Assert.That(dotProduct, Is.EqualTo(12));
        }

        [Test]
        public void calculate_sum_of_squares()
        {
            Vector vector = new Vector(1, 2);


            int sum = vector.sumOfSquares();


            Assert.That(sum, Is.EqualTo(5));
        }

        [Test]
        public void calculate_magnitude()
        {
            Vector vector = new Vector(4, 3);


            double magnitude = vector.magnitude();


            Assert.That(magnitude, Is.EqualTo(5.0));
        }

        [Test]
        public void calculate_squared_distance_between_itself_and_another_vector()
        {
            Vector vector = new Vector(6, 8);
            Vector anotherVector = new Vector(2, 6);


            int squaredDistance = vector.squaredDistanceFrom(anotherVector);


            Assert.That(squaredDistance, Is.EqualTo(20));
        }

        [Test]
        public void calculate_distance_between_itself_and_another_vector()
        {
            Vector vector = new Vector(5, 8);
            Vector anotherVector = new Vector(2, 4);


            double distance = vector.distanceFrom(anotherVector);


            Assert.That(distance, Is.EqualTo(5.0));
        }
    }
}
