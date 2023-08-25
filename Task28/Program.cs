/*
Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
*/
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());


int MultOfNumber(int number)
{
    int mult = 1;
for (int i = 1; i <= userNumber; i++)
{
    mult *= i;
}
    return mult;
}
System.Console.WriteLine($"Произведение цифр в числе {userNumber} равна {MultOfNumber(userNumber)}");