/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
12 : 13
5, 25 -> yes
-4, 16 -> yes
25, 5 -> yes
8, 9 -> no
*/

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2*number2 || number2 == number1*number1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}