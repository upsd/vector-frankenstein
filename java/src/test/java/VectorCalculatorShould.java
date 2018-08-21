import org.junit.Test;

import java.util.Arrays;
import java.util.List;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.assertThat;

public class VectorCalculatorShould {

    @Test
    public void sum_multiple_vectors() {
        List<Vector> vectors = Arrays.asList(new Vector(1, 2), new Vector(2, 3), new Vector(4, 8));


        Vector sum = VectorCalculator.sum(vectors);


        assertThat(sum, is(new Vector(7, 13)));
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
}