using NUnit.Framework;
using System.Collections.Generic;

namespace VectorFrankenstein.Tests
{
    [TestFixture]
    public class VectorCalculatorShould
    {
        [Test]
        public void sum_multiple_vectors()
        {
            List<Vector> vectors = new List<Vector>()
            {
                new Vector(1, 2),
                new Vector(2, 3),
                new Vector(4, 8)
            };


            Vector sum = VectorCalculator.sum(vectors);


            Assert.That(sum, Is.EqualTo(new Vector(7, 13)));
        }

        [Test]
        public void calculate_mean_of_vectors()
        {
            List<Vector> vectors = new List<Vector>()
            {
                new Vector(2, 4),
                new Vector(5, 2),
                new Vector(8, 3)
            };


            Vector mean = VectorCalculator.meanOf(vectors);


            Assert.That(mean, Is.EqualTo(new Vector(5, 3)));
        }
    }
}
