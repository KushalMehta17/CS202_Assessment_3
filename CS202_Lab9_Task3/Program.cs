public class ArrayOperations
{
    // Method to implement bubble sort
    public void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Method to convert 2D array to 1D in row-major order
    public int[] ConvertToRowMajor(int[,] matrix2D)
    {
        int rows = matrix2D.GetLength(0);
        int cols = matrix2D.GetLength(1);
        int[] result = new int[rows * cols];

        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[index++] = matrix2D[i, j];
            }
        }
        return result;
    }

    // Method to convert 2D array to 1D in column-major order
    public int[] ConvertToColumnMajor(int[,] matrix2D)
    {
        int rows = matrix2D.GetLength(0);
        int cols = matrix2D.GetLength(1);
        int[] result = new int[rows * cols];

        int index = 0;
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                result[index++] = matrix2D[i, j];
            }
        }
        return result;
    }

    // Method for matrix multiplication
    public int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
        {
            throw new ArgumentException("Matrix dimensions are incompatible for multiplication");
        }

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return result;
    }

    // Utility method to print 1D array
    public void PrintArray(int[] arr)
    {
        Console.Write("[ ");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("]");
    }

    // Utility method to print 2D array
    public void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4) + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Array Operations Demonstration ===\n");

        ArrayOperations arrayOps = new ArrayOperations();

        // Task 1: Bubble Sort Implementation
        DemonstrateBubbleSort(arrayOps);

        // Task 2: 2D to 1D Array Conversion
        DemonstrateArrayConversion(arrayOps);

        // Task 3: Matrix Multiplication
        DemonstrateMatrixMultiplication(arrayOps);
    }

    static void DemonstrateBubbleSort(ArrayOperations arrayOps)
    {
        Console.WriteLine("1. BUBBLE SORT IMPLEMENTATION");
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
        Console.Write("Original array: ");
        arrayOps.PrintArray(numbers);

        arrayOps.BubbleSort(numbers);
        Console.Write("Sorted array: ");
        arrayOps.PrintArray(numbers);
        Console.WriteLine();
    }

    static void DemonstrateArrayConversion(ArrayOperations arrayOps)
    {
        Console.WriteLine("2. 2D TO 1D ARRAY CONVERSION");
        int[,] matrix2D = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Original 2D Matrix:");
        arrayOps.PrintMatrix(matrix2D);

        int[] rowMajor = arrayOps.ConvertToRowMajor(matrix2D);
        Console.Write("Row Major Order: ");
        arrayOps.PrintArray(rowMajor);

        int[] columnMajor = arrayOps.ConvertToColumnMajor(matrix2D);
        Console.Write("Column Major Order: ");
        arrayOps.PrintArray(columnMajor);
        Console.WriteLine();
    }

    static void DemonstrateMatrixMultiplication(ArrayOperations arrayOps)
    {
        Console.WriteLine("3. MATRIX MULTIPLICATION");

        int[,] matrixA = {
            {1, 2, 3},
            {4, 5, 6}
        };

        int[,] matrixB = {
            {7, 8},
            {9, 10},
            {11, 12}
        };

        Console.WriteLine("Matrix A (2x3):");
        arrayOps.PrintMatrix(matrixA);

        Console.WriteLine("Matrix B (3x2):");
        arrayOps.PrintMatrix(matrixB);

        try
        {
            int[,] result = arrayOps.MatrixMultiplication(matrixA, matrixB);
            Console.WriteLine("Result Matrix C (2x2):");
            arrayOps.PrintMatrix(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


