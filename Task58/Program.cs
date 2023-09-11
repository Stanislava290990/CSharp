/*
Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/

const int size = 3; 
int[,] array1 = CreateMatrix();
int[,] array2 = CreateMatrix();
int[,] mult = MatrixMultiplication(array1, array2);

Console.WriteLine("\nМатрица 1");
PrintMatrix(array1);
Console.WriteLine("Матрица 2");
PrintMatrix(array2);
Console.WriteLine("Произведение матриц 1 и 2");
PrintMatrix(mult);

int[,] CreateMatrix()
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] ab = new int[matr1.GetLength(0), matr2.GetLength(1)];    
    for (int i = 0; i < ab.GetLength(0); i++)
    {
        for (int j = 0; j < ab.GetLength(1); j++)
        {
            ab[i, j] = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                ab[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return ab;
}
