/*
Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой 
 четверти (x и y).
 */
System.Console.WriteLine("Введите номер четверти :");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater ==1)
{
   System.Console.WriteLine("x and y +"); 
}
else if(quater ==2)
{
   System.Console.WriteLine("x - , y +"); 
}
else if(quater ==3)
{
   System.Console.WriteLine("x and y -"); 
}
else if(quater ==2)
{
   System.Console.WriteLine("x + , y -"); 
}
else
{
System.Console.WriteLine("Нет такой четверти ");
}