from __future__ import division
import math

def add(v, w):
    """adds corresponding elements from both vectors v and w
    e.g. [5, 4] [3, 6]
    = [5 + 3] [4 + 6]
    = [8, 10]
    """
    return [v_i + w_i
            for v_i, w_i in zip(v, w)]

def subtract(v, w):
    """subtracts corresponding elements from both vectors v and w
    e.g. [3, 9] [2, 7]
    = [3 - 2] [9 - 7]
    = [1, 2]
    """
    return [v_i - w_i
            for v_i, w_i in zip(v, w)]

def sum_vectors(vectors):
    """sums the ith element of each vector
    e.g. [1, 2] [3, 6] [4, 2]
    = [1 + 3 + 4] [2 + 6 + 2]
    = [8, 10]
    """
    return reduce(add, vectors)

def scalar_multiply(c, v):
    """multiply elements of a vector by a scalar
    e.g. scalar = 2, vector = [4, 12]
    = [4 * 2, 12 * 2]
    = [8, 24]
    """
    return [c * v_i for v_i in v]

def mean(vectors):
    """compute the vector whose ith element is the mean of the ith elements of the input vectors
    e.g. [[1, 2] [4, 7] [6, 2]]
    = [(1 + 4 + 6) / 3, (2 + 7 + 2) / 3]
    = [11 / 3, 11 / 3]
    = [3.66, 3.66]
    """
    n = len(vectors)
    return scalar_multiply(1 / n, sum_vectors(vectors))

def dot(v, w):
    """e.g. [1, 2] [8, 2]
    = (1 * 8) + (2 * 2)
    = 8 * 4
    = 12
    """
    return sum(v_i * w_i for v_i, w_i in zip(v, w))

def sum_of_squares(v):
    """sums the square of a vector
    e.g. [1, 2]
    = [1 * 1] + [2 * 2]
    = 1 + 4
    = 5
    """
    return dot(v, v)

def magnitude(v):
    """calculates the length (magnitude) of a vector
    e.g. [4, 3]
    = sqrt( [4 * 4] + [3 * 3] )
    = sqrt(16 + 9)
    = sqrt(25)
    = 5
    """
    return math.sqrt(sum_of_squares(v))

def squared_distance(v, w):
    """calculates the squared distance between two vectors
    e.g. [5, 3] [9, 6]
    = ([5 - 3] ^ 2) + ([ 9 - 6] ^ 2)
    = (2 ^ 2) + (3 ^ 2)
    = 4 + 9
    = 13
    """
    return sum_of_squares(subtract(v, w))

def distance(v, w):
    """calculates the distance between two vectors
    e.g. [5, 8] [2, 4]
    = sqrt(([5 - 2] ^ 2) + ([8 - 4] ^ 2))
    = sqrt((3 ^ 2) + (4 ^ 2))
    = sqrt(9 + 16)
    = sqrt(25)
    = 5
    """
    return magnitude(subtract(v, w))