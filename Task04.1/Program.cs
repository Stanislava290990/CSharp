/*Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
*/

Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(max>number2 && max>number3)
{
    Console.WriteLine("Max first number");
}
else if(number2>max && number2>number3)
{
    Console.WriteLine("Max second number");
}
else if (number3>max && number3>number2)
{
    Console.WriteLine("Max third number");
}
