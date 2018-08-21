import java.util.List;

import static java.lang.Math.sqrt;

public class VectorCalculator {

    public static Vector add(Vector vectorA, Vector vectorB) {
        int sumOfX = vectorA.x() + vectorB.x();
        int sumOfY = vectorA.y() + vectorB.y();

        return new Vector(sumOfX, sumOfY);
    }

    public static Vector subtract(Vector vectorA, Vector vectorB) {
        int differenceInX = vectorA.x() - vectorB.x();
        int differenceInY = vectorA.y() - vectorB.y();

        return new Vector(differenceInX, differenceInY);
    }

    public static Vector sum(List<Vector> vectors) {
        int sumOfX = vectors.stream().mapToInt(v -> v.x()).sum();
        int sumOfY = vectors.stream().mapToInt(v -> v.y()).sum();

        return new Vector(sumOfX, sumOfY);
    }

    public static Vector multiply(Vector vector, int multiplier) {
        return new Vector(vector.x() * multiplier, vector.y() * multiplier);
    }

    public static Vector meanOf(List<Vector> vectors) {
        Vector summed = sum(vectors);
        int meanOfX = summed.x() / vectors.size();
        int meanOfY = summed.y() / vectors.size();

        return new Vector(meanOfX, meanOfY);
    }

    public static int dotProductFor(Vector vector, Vector anotherVector) {
        int xMultiplied = vector.x() * anotherVector.x();
        int yMultiplied = anotherVector.y() * anotherVector.y();

        return xMultiplied + yMultiplied;
    }

    public static int sumOfSquaresFor(Vector vector) {
        return dotProductFor(vector, vector);
    }

    public static double magnitudeOf(Vector vector) {
        return sqrt(sumOfSquaresFor(vector));
    }

    public static int squaredDistanceBetween(Vector vector, Vector anotherVector) {
        return sumOfSquaresFor(subtract(vector, anotherVector));
    }

    public static double distanceBetween(Vector vector, Vector anotherVector) {
        return magnitudeOf(subtract(vector, anotherVector));
    }
}
