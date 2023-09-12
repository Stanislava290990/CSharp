 /*Задайте значения M и N. Напишите программу, которая найдёт 
 сумму натуральных элементов в промежутке от M до N.
*/
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

double NumbersSum(int a, int b)
{
    if (a == b || a + 1 == b || a == b + 1) 
    {
        return 0;   // нет элементов в промежутке
    }
    else if (a > b) 
    {
        return b + 1 + NumbersSum(a, b + 1);
    }
    else
    {
     return a + 1 + NumbersSum(a + 1, b);
    }
}

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {NumbersSum(m, n)}.");
