// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int ElementSum(int newM, int newN)
{
    if (newM > newN)
    {
        newM = newM + ElementSum(newM - 1, newN);
    }

     if (newM < newN)
    {
        newM = newM + ElementSum(newM + 1, newN);
    }

    return newM;
}

if (m < 0)
{
    Console.WriteLine("Введите число M больше нуля: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {ElementSum(m, n)}");
}

else if (n < 0)
{
    Console.WriteLine("Введите число N больше нуля: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {ElementSum(m, n)}");
}

else
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {ElementSum(m, n)}");
}