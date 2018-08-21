import unittest
import vectors

class MyTest(unittest.TestCase):
    def test_can_add_vectors(self):
        vector_a = [1, 2]
        vector_b = [2, 1]
        self.assertEqual(vectors.add(vector_a, vector_b), [3, 3])

    def test_can_subtract_vectors(self):
        vector_a = [5, 3]
        vector_b = [4, 1]
        self.assertEqual(vectors.subtract(vector_a, vector_b), [1, 2])

    def test_can_sum_vectors(self):
        vectors_to_sum = [[1, 2], [1, 2], [3, 2]]
        self.assertEqual(vectors.sum_vectors(vectors_to_sum), [5, 6])

    def test_can_multiply_vector_by_scalar(self):
        scalar = 2
        vector_to_multiply = [2, 6]
        self.assertEqual(vectors.scalar_multiply(scalar, vector_to_multiply), [4, 12])

    def test_can_calculate_mean_of_vectors(self):
        vectors_to_calculate_mean = [[2, 4], [5, 2], [8, 3]]
        expected_vector_mean = [5, 3]
        self.assertEqual(vectors.mean(vectors_to_calculate_mean), expected_vector_mean)

    def test_can_calculate_dot_product_of_two_vectors(self):
        self.assertEqual(vectors.dot([1, 2], [8, 2]), 12)

    def test_can_calculate_sum_of_squares(self):
        self.assertEqual(vectors.sum_of_squares([1, 2]), 5)

    def test_can_calculate_magnitude_of_vector(self):
        self.assertEqual(vectors.magnitude([4, 3]), 5)

    def test_can_compute_squared_distance(self):
        vector_a = [6, 8]
        vector_b = [2, 6]
        self.assertEquals(vectors.squared_distance(vector_a, vector_b), 20)

    def test_can_calculate_distance(self):
        vector_a = [5, 8]
        vector_b = [2, 4]
        self.assertEquals(vectors.distance(vector_a, vector_b), 5)

if __name__ == '__main__':
    unittest.main()