using System.Collections.Generic;
using System.Linq;

namespace VectorFrankenstein
{
    public class VectorCalculator
    {
        public static Vector sum(List<Vector> vectors)
        {
            int sumOfX = vectors.Select(v => v.X()).Sum();
            int sumOfY = vectors.Select(v => v.Y()).Sum();

            return new Vector(sumOfX, sumOfY);
        }

        public static Vector meanOf(List<Vector> vectors)
        {
            Vector summed = sum(vectors);
            int meanOfX = summed.X() / vectors.Count();
            int meanOfY = summed.Y() / vectors.Count();

            return new Vector(meanOfX, meanOfY);
        }
    }
}
