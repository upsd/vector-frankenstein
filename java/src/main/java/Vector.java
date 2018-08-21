import java.util.Objects;

import static java.lang.Math.sqrt;

public class Vector {

    private final int x;
    private final int y;

    public Vector(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int x() {
        return this.x;
    }

    public int y() {
        return this.y;
    }

    public Vector add(Vector vector) {
        int sumOfX = x() + vector.x();
        int sumOfY = y() + vector.y();

        return new Vector(sumOfX, sumOfY);
    }

    public Vector subtract(Vector vector) {
        int differenceInX = x() - vector.x();
        int differenceInY = y() - vector.y();

        return new Vector(differenceInX, differenceInY);
    }

    public Vector multiplyBy(int multiplier) {
        return new Vector(x() * multiplier, y() * multiplier);
    }

    public int dotProductWith(Vector anotherVector) {
        int xMultiplied = x() * anotherVector.x();
        int yMultiplied = y() * anotherVector.y();

        return xMultiplied + yMultiplied;
    }

    public int sumOfSquares() {
        return dotProductWith(this);
    }

    public double magnitude() {
        return sqrt(sumOfSquares());
    }

    public double distanceFrom(Vector anotherVector) {
        return subtract(anotherVector).magnitude();
    }

    public int squaredDistanceFrom(Vector anotherVector) {
        return subtract(anotherVector).sumOfSquares();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Vector vector = (Vector) o;
        return x == vector.x &&
                y == vector.y;
    }

    @Override
    public int hashCode() {

        return Objects.hash(x, y);
    }
}
