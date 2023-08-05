/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все числа от -N до N
*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -number; i <= number; i++)
{
    Console.Write(i + " ");
}
