/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все четные числа от 1 до N
*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i=i+2)
{
    Console.Write(i + " ");
}