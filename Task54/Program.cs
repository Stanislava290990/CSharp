/*
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество строк массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr = FillMatrixRnd(m, n);
        PrintMatrix(arr);
        SortMatrix(arr);
        PrintMatrix(arr);

        // Заполнение массива случайными числами
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

        // Сортировка по убыванию элементов каждой строки
        void SortMatrix(int[,] array)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int k = j; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] < array[i, k])
                            (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
                    }
                }
            }
}
}