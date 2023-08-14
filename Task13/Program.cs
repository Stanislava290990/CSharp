/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOne = number % 100;

if(number.Lenght > 2)
{
Console.WriteLine($"{numberOne}");
}
else
{
    Console.WriteLine("Третьего числа нет: ");
}