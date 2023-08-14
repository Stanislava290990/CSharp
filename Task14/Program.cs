/* 
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> no
46-> no
161 -> yes
*/

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

if (number % (number1 * number2) ==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
