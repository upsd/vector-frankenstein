import org.junit.Test;

import java.util.Arrays;
import java.util.List;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.assertThat;

public class VectorCalculatorShould {

    @Test
    public void add_two_vectors() {
        Vector vectorA = new Vector(1, 2);
        Vector vectorB = new Vector(2, 1);


        Vector added = VectorCalculator.add(vectorA, vectorB);


        assertThat(added, is(new Vector(3, 3)));
    }

    @Test
    public void subtract_two_vectors() {
        Vector vectorA = new Vector(5, 4);
        Vector vectorB = new Vector(3, 10);


        Vector subtracted = VectorCalculator.subtract(vectorA, vectorB);


        assertThat(subtracted, is(new Vector(2, -6)));
    }

    @Test
    public void sum_multiple_vectors() {
        List<Vector> vectors = Arrays.asList(new Vector(1, 2), new Vector(2, 3), new Vector(4, 8));


        Vector sum = VectorCalculator.sum(vectors);


        assertThat(sum, is(new Vector(7, 13)));
    }

    @Test
    public void multiply_vector_by_scalar() {
        Vector vector = new Vector(1, 2);


        Vector vectorMultiplied = VectorCalculator.multiply(vector, 2);


        assertThat(vectorMultiplied, is(new Vector(2, 4)));
    }

    @Test
    public void calculate_mean_of_vectors() {
        List<Vector> vectors = Arrays.asList(
                new Vector(2, 4),
                new Vector(5, 2),
                new Vector(8, 3)
        );


        Vector mean = VectorCalculator.meanOf(vectors);


        assertThat(mean, is(new Vector(5, 3)));
    }

    @Test
    public void calculate_dot_product_of_two_vectors() {
        Vector vector = new Vector(1, 2);
        Vector anotherVector = new Vector(8, 2);


        int dotProduct = VectorCalculator.dotProductFor(vector, anotherVector);


        assertThat(dotProduct, is(12));
    }

    @Test
    public void calculate_sum_of_squares() {
        int sum = VectorCalculator.sumOfSquaresFor(new Vector(1, 2));


        assertThat(sum, is(5));
    }

    @Test
    public void calculate_magnitude_of_vector() {
        double magnitude = VectorCalculator.magnitudeOf(new Vector(4, 3));


        assertThat(magnitude, is(5.0));
    }

    @Test
    public void calculate_squared_distance_between_two_vectors() {
        Vector vector = new Vector(6, 8);
        Vector anotherVector = new Vector(2, 6);


        int squaredDistance = VectorCalculator.squaredDistanceBetween(vector, anotherVector);


        assertThat(squaredDistance, is(20));
    }

    @Test
    public void calculate_distance_between_two_vectors() {
        Vector vector = new Vector(5, 8);
        Vector anotherVector = new Vector(2, 4);


        double distance = VectorCalculator.distanceBetween(vector, anotherVector);


        assertThat(distance, is(5.0));
    }
}