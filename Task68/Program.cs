/* Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
    */

double ackerman(double m, double n)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = ackerman(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

// int ackM = 1;
// int ackN = 1;
// Console.WriteLine($"ack({ackM}, {ackN}) = {ack(ackM, ackN)}");

for (int i = 0; i < 4; i++) // переполнение при расчете ack(3,1))
{
    Console.WriteLine();
    for (int j = 0; j < 2; j++) // при j = 3 переполнение ~19k повторов :)
        Console.Write($"ackerman({i}, {j}) = {ackerman(i, j)}\t");
}
