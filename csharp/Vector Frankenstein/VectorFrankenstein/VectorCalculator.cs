using System.Collections.Generic;
using System.Linq;

namespace VectorFrankenstein
{
    public class VectorCalculator
    {
        public static Vector Sum(List<Vector> vectors)
        {
            var sumOfX = vectors.Select(v => v.X()).Sum();
            var sumOfY = vectors.Select(v => v.Y()).Sum();

            return new Vector(sumOfX, sumOfY);
        }

        public static Vector MeanOf(List<Vector> vectors)
        {
            var summed = Sum(vectors);
            var meanOfX = summed.X() / vectors.Count;
            var meanOfY = summed.Y() / vectors.Count;

            return new Vector(meanOfX, meanOfY);
        }
    }
}
