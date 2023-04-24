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

void PrintArray(string message, int[] array)
{
    Console.Write($"{message} [{array[0]}");
    for (int i=1; i<array.Length; i++)
        Console.Write($", {array[i]}");
    Console.WriteLine("]");
}

int[] CreateIntRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
void PrintArrayEvenNumbers(string message, int[] array)
{
    string separator = "";
    Console.Write($"{message}");
    for (int i=0; i<array.Length; i++)
        if (array[i] % 2 == 0)
        {
            Console.Write($"{separator}{array[i]}");
            separator = ", ";
        }
    Console.WriteLine("");
}

int size34 = PromptInt("Enter an array size > ");
int[] array34 = CreateIntRandomArray(size34, 100, 999);
PrintArray("New random array : ", array34);
PrintArrayEvenNumbers("Only even numbers in array : ", array34);
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int GetSumOddElements(int[] array)
{
    int result = 0;
    for (int i=0; i<array.Length; i++)
        if ((i+1)%2==1)
            result += array[i];
    return result;
}

int size36 = PromptInt("Enter an array size > ");
int minV = PromptInt("Enter a minimum value > ");
int maxV = PromptInt("Enter a maximum value > ");
int[] array36 = CreateIntRandomArray(size36, minV, maxV);
PrintArray("New random array : ", array36);
Console.WriteLine($"Sum of odd elements : {GetSumOddElements(array36)}");
*/
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillDoubleArray(double[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = PromptDouble($"Enter {i+1} element > ");
    }
}

double VisibleDouble(double number) {
    return Math.Round(number,2);
}

void PrintDblArray(string message, double[] array)
{
    Console.Write($"{message} [{VisibleDouble(array[0])}");
    for (int i=1; i<array.Length; i++)
        Console.Write($", {VisibleDouble(array[i])}");
    Console.WriteLine("]");
}

double GetMinDbl(double[] array)
{
    double minValue = double.MaxValue;
    for (int i=0; i<array.Length; i++)
        if (array[i]<minValue) minValue=array[i];
    return minValue;
}

double GetMaxDbl(double[] array)
{
    double maxValue = double.MinValue;
    for (int i=0; i<array.Length; i++)
        if (array[i]>maxValue) maxValue=array[i];
    return maxValue;
}

int size38 = PromptInt("Enter an array size > ");
double[] array38 = new double[size38];
FillDoubleArray(array38);
PrintDblArray("New handmade array : ", array38);
double minVal = GetMinDbl(array38);// find min
double maxVal = GetMaxDbl(array38);// find max
Console.WriteLine($"Diffrence beetween max and min : {VisibleDouble(maxVal-minVal)}");// print diffrence


