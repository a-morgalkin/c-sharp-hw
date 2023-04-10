// Task #2
// Программа принимает на вход два числа и выдает большее
// >>> a = 5; b = 7 -> max = 7
// >>> a = 2; b = 10 > max = 10
// >>> a = -9; b = -3 - > max = -3
/*
string input = "";

Console.Write("Введите первое число: ");
input = Console.ReadLine();
int num1 = Convert.ToInt32(input);

Console.Write("Введите второе число: ");
input = Console.ReadLine();
int num2 = Convert.ToInt32(input);

int max = num1;
if (max < num2) max = num2;

Console.WriteLine($"Максимальное число: {max}");
*/

// Task #4 
// Программа принимает три числа и выдает максимальное из трех
// example: 2, 3, 7 -> 7
/*
string input = "";
int num1 = 0;
int num2 = 0;
int num3 = 0;
int value;

Console.Write("Введите первое число: ");
input = Console.ReadLine();
if (!(int.TryParse(input, out value)))
{
    num1 = new Random().Next(1,100);
    Console.WriteLine($"Для ясности, будем считать что это {num1}");
}

Console.Write("Введите второе число: ");
input = Console.ReadLine();
if (!(int.TryParse(input, out num2)))
{
    num2 = new Random().Next(1,100);
    Console.WriteLine($"Для ясности, будем считать что это {num2}");
}

Console.Write("Введите третье число: ");
input = Console.ReadLine();
if (!(int.TryParse(input, out num3)))
{
    num3 = new Random().Next(1,100);
    Console.WriteLine($"Для ясности, будем считать что это {num3}");
}

int max = num1;
if (max < num2) max = num2;
if (max < num3) max = num3;

Console.WriteLine($"Максимальное число: {max}");
*/

// Task #6
// Программа принимает и проверяет число на четность
// exmaples:
// 4 -> да
// -3 -> нет
/*
string input = "";
string result = "";

Console.Write("Введите целое число: ");
input = Console.ReadLine();
int num = Convert.ToInt32(input);
if ((num % 2) == 0) result = "да";
else result = "нет";

Console.WriteLine($"Число четное? {result}");
*/

// Task #8
// Программа принимает число N, на выходе показвыает все четные от 1 до N
// examples: 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int count = 2;
Console.Write("Введите целое число (N > 0): ");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);

while (count < n)
{
    Console.WriteLine(count);
    count += 2;
}

