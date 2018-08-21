import java.util.List;

public class VectorCalculator {

    public static Vector sum(List<Vector> vectors) {
        int sumOfX = vectors.stream().mapToInt(v -> v.x()).sum();
        int sumOfY = vectors.stream().mapToInt(v -> v.y()).sum();

        return new Vector(sumOfX, sumOfY);
    }

    public static Vector meanOf(List<Vector> vectors) {
        Vector summed = sum(vectors);
        int meanOfX = summed.x() / vectors.size();
        int meanOfY = summed.y() / vectors.size();

        return new Vector(meanOfX, meanOfY);
    }
}
