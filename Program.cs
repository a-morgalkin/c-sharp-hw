int PromptInt(string message)
{
Console.Write(message);
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
return result;
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
string exit = "n";
int numA;
int numB;
while (exit != "y")
{
    numA = PromptInt("Enter a number A > ");
    numB = PromptInt("Enter a number B > ");
    Console.WriteLine($"{numA} ^ {numB} = {Math.Pow(numA, numB)}");
    Console.Write("Exit ? (y/n) > ");
    exit = Console.ReadLine().ToLower();
}
*/

// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumDigits(int num)
{
    int result =0;
    num = Math.Abs(num);
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
int num = PromptInt("Enter a number > ");
Console.WriteLine($"Sum of digtits : {SumDigits(num)}");
*/

// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array, int max)
{
    Random rnd = new Random();
    for (int i=0; i<array.Length; i++)
        array[i]=rnd.Next(max+1);
    return;
}

void PrintArray(int[] array)
{
    Console.Write($"New array: [{array[0]}");
    for (int i=1; i<array.Length; i++)
        Console.Write($", {array[i]}");
    Console.WriteLine("]");
}

int n = PromptInt("Enter an array size > ");
int max = PromptInt("Enter a maximum element value > ");
int[] array = new int[n];
FillArray(array, max);
PrintArray(array);
