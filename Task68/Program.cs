// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int newM, int newN)
{
    if (newM == 0) return newN + 1;
    else if ((newM != 0) && (newN == 0)) return Ackermann(newM - 1, 1);
    else return Ackermann(newM - 1, Ackermann(newM, newN - 1));
}

if (m < 0)
{
    Console.WriteLine("Введите неотрицательное число M: ");
    m = Convert.ToInt32(Console.ReadLine());
    int ackermann = Ackermann(m, n);
    Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {ackermann}");
}
else if (n < 0)
{
    Console.WriteLine("Введите неотрицательное число N: ");
    n = Convert.ToInt32(Console.ReadLine());
    int ackermann = Ackermann(m, n);
    Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {ackermann}");
}

else
{
    int ackermann = Ackermann(m, n);
    Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {ackermann}");
}