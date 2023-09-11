/*
Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов
*/
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {IndexMinRow(arr) + 1}"); 

int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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

int IndexMinRow(int[,] matrix)
{
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        sumRows[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRows[i] += matrix[i, j];
        }
    }
    int min = sumRows[0];
    int minIndex = 0;
    for (int i = 1; i < matrix.GetLength(0); i++) 
        if (min > sumRows[i])
        {
            min = sumRows[i];
            minIndex = i;
        }
    return minIndex;
}
