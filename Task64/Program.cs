// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите натруальное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void FromNToOne(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    FromNToOne(num - 1);
}

if (n < 0)
{
    Console.WriteLine("Введите число больше нуля: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Числа в промежутке от {n} до 1: ");
    FromNToOne(n);

}

else
{
    Console.WriteLine($"Числа в промежутке от от {n} до 1: ");
    FromNToOne(n);
}
