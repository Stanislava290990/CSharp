/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
System.Console.WriteLine("Введите 5ти значное число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int numberTurn = 0;

if (userNumber < 0) userNumber = userNumber * -1;

if (userNumber > 9999 && userNumber < 100000)
{
    for (int i = userNumber; i > 0; i /= 10)
    {
        numberTurn = i % 10 + numberTurn * 10;
    }
if (userNumber == numberTurn)
    System.Console.WriteLine("True");
else 
System.Console.WriteLine("False");
}
else
    System.Console.WriteLine("Error");
