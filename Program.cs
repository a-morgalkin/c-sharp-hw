int PromptInt(string message)
{
Console.Write(message);
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
return result;
}

double PromptDouble(string message)
{
Console.Write(message);
string input = Console.ReadLine();
double result = Convert.ToDouble(input);
return result;    
}

void PrintInt2dArray(int[,] array, int colWide = 8)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(Convert.ToString(array[i,j]).PadLeft(colWide));
        Console.WriteLine();
    }
}

int[,] CrRandomInt2dArray(int lines, int columns, int maxValue)
{
    int[,] array = new int[lines, columns];
    for(int i = 0; i<lines; i++)
        for(int j=0; j<columns; j++)
            array[i,j] = new Random().Next(maxValue+1);
    return array;
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] CrRandomDbr2dArray(int lines, int columns, double maxValue)
{
    double[,] array = new double[lines, columns];
    for(int i = 0; i<lines; i++)
        for(int j=0; j<columns; j++)
            array[i,j] = new Random().NextDouble() * maxValue 
                      * (new Random().NextDouble() > 0.5 ? 1: -1);
    return array;
}

void PrintDbl2dArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j].ToString("0.00").PadLeft(8));
        Console.WriteLine();
    }
}

int m = PromptInt("Enter an array size (lines) > ");
int n = PromptInt("Enter an array size (columns) > ");
double max = PromptDouble("Enter a max abs value (double) > ");
double[,] myArray47 = CrRandomDbr2dArray(m, n, max);
PrintDbl2dArray(myArray47);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
bool OutOfRange2d(int i, int j, int[,] array)
{
    if (i >= 0 &&
        i < array.GetLength(0) && 
        j >= 0 &&
        j < array.GetLength(1)) 
            return false;
    return true;
}

int[,] myArray50 = CrRandomInt2dArray(5, 5, 10);
PrintInt2dArray(myArray50, 6);
int i = PromptInt("Enter i index for array [i, j] > ");
int j = PromptInt("Enter j index for array [i, j] > ");
if (OutOfRange2d(i, j, myArray50))
    Console.WriteLine($"No element [{i}, {j}] in this array");
else
    Console.WriteLine($"Element [{i}, {j}] value: {myArray50[i,j]}");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double GetColAverage(int[,] array, int column)
{
// double[] colAverage = new double[array.GetLength(1)];
double sum = 0;
// double colAverage=0;
for (int i=0; i < array.GetLength(0); i++)
    sum += array[i,column];
// colAverage = sum/array.GetLength(0);
return sum / array.GetLength(0);
}

void PrintColAverage(int[,] array, int colWide = 8)
{
for (int j=0; j<array.GetLength(1);j++)
    Console.Write(GetColAverage(array,j).ToString("0.00").PadLeft(colWide));
Console.WriteLine();
}

int m52 = PromptInt("Enter an array size (lines) > ");
int n52 = PromptInt("Enter an array size (columns) > ");
int max52 = PromptInt("Enter a max value (integer) > ");
int wide = Convert.ToInt32(Math.Log10(max52) + 4);
int[,] myArray52 = CrRandomInt2dArray(m52, n52, max52);
Console.WriteLine("Your array :");
PrintInt2dArray(myArray52, wide);
Console.WriteLine("Average :");
PrintColAverage(myArray52, wide);
