using NUnit.Framework;
using System.Collections.Generic;

namespace VectorFrankenstein.Tests
{
    [TestFixture]
    public class VectorCalculatorShould
    {
        [Test]
        public void Sum_Multiple_Vectors()
        {
            var vectors = new List<Vector>()
            {
                new Vector(1, 2),
                new Vector(2, 3),
                new Vector(4, 8)
            };


            var sum = VectorCalculator.Sum(vectors);


            Assert.That(sum, Is.EqualTo(new Vector(7, 13)));
        }

        [Test]
        public void Calculate_Mean_Of_Vectors()
        {
            var vectors = new List<Vector>()
            {
                new Vector(2, 4),
                new Vector(5, 2),
                new Vector(8, 3)
            };


            var mean = VectorCalculator.MeanOf(vectors);


            Assert.That(mean, Is.EqualTo(new Vector(5, 3)));
        }
    }
}
