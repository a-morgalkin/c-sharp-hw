// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumTo1(int n)
{
    if(n < 1)
        Console.WriteLine("N must be greater 0");
    if(n > 1) {
        Console.Write($"{n}, "); // вывод при погружении
        PrintNumTo1(n-1);
    }
    if(n == 1) Console.WriteLine(n); // условие выхода
}

Console.WriteLine("--- Задача 64 ---");
PrintNumTo1(10);

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumMtoN(int m, int n) {
    if(m <= n) return m + SumMtoN(m + 1, n);
    return 0;
}

Console.WriteLine("--- Задача 66 ---");
Console.WriteLine(SumMtoN(1, 15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int a, int b)
{
    if(a == 0) return b + 1;
    else if(b == 0) return Ackermann(a-1, 1);
    return Ackermann(a - 1, Ackermann(a, b - 1));
}
Console.WriteLine("--- Задача 68 ---");
Console.WriteLine(Ackermann(3, 2));
