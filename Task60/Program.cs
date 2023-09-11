/*
Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/

Console.Write("Введите количество строк массива (X): ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (Y): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество страниц массива (Z): ");
int page = Convert.ToInt32(Console.ReadLine());

int[,,] arr = FillUniqNums(col, row, page);
PrintMatrix(arr);


int[,,] FillUniqNums(int row1, int col1, int page1)
{
    int[,,] matrix = new int[row1, col1, page1];
    for (int k = 0; k < matrix.GetLength(2); k++)   
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j, k] = 0;
            }
        }
    }
    int rnd = new Random().Next(10, 100);
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                while (NotUnique(matrix, rnd))  
                    rnd = new Random().Next(10, 100);
                matrix[i, j, k] = rnd;        
            }
        }
    }
    return matrix;
}

bool NotUnique(int[,,] matrix, int num)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j, k] == num)
                    return true;
            }
        }
    }
    return false;
}


void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        Console.WriteLine($"Page {k}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}