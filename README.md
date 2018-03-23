# Vector Frankenstein (I know it's Victor)
This is a simple library for working with vectors, created whilst reading DS From Scratch.

## Pre-requisites
You will need `Python 2.7.x`.
## Run the tests

	$ python vectors_test.py
 
## Using the library
After downloading this repo, you can import the `vectors.py` file, and do something like the below at the top of your
file:
```python
import vectors
```
### Add vectors
```python
vector_a = [1, 2]
vector_b = [2, 1]
vectors.add(vector_a, vector_b)
```
### Subtract vectors
```python
vector_a = [5, 3]
vector_b = [4, 1]
vectors.subtract(vector_a, vector_b)
```
### Sum vectors
```python
vectors_to_sum = [[1, 2], [1, 2], [3, 2]]
vectors.sum_vectors(vectors_to_sum)
```
### Multiply vector by scalar
```python
scalar = 2
vector_to_multiply = [2, 6]
vectors.scalar_multiply(scalar, vector_to_multiply)
```
### Mean of vectors
```python
vectors_to_calculate_mean = [[2, 4], [5, 2], [8, 3]]
vectors.mean(vectors_to_calculate_mean)
```
### Dot product
```python
vectors.dot([1, 2], [8, 2])
```
### Sum of squares
```python
vectors.sum_of_squares([1, 2])
```
### Magnitude of vector
```python
vectors.magnitude([4, 3])
```
### Squared distance between vectors
```python
vector_a = [6, 8]
vector_b = [2, 6]
vectors.squared_distance(vector_a, vector_b)
```
### Distance between vectors
```python
vector_a = [5, 8]
vector_b = [2, 4]
vectors.distance(vector_a, vector_b)
```
