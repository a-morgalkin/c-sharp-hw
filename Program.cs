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

int[] GetHandArray(int size)
{
    int[] result = new int[size];
    for (int i=0; i<result.Length; i++)
    {
        result[i] = PromptInt($"Enter {i+1} element > ");
    }
    return result;
}

double VisibleDouble(double number) {
    return Math.Round(number,2);
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetPositiveQty(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
        if (array[i]>0) count++;
    return count;
}

int numM = PromptInt("Enter a M number > ");
int[] array41 = GetHandArray(numM);
Console.WriteLine($"Quantity of positive numbers : {GetPositiveQty(array41)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionLines(double[] line1, double[] line2)
{
    int k = 0;
    int b = 1;
    double x = (line2[b] - line1[b])/(line1[k] - line2[k]);
    double y = line1[k]*x + line1[b];
    double[] point = {x, y};
    return point;
}

double[] PromptLine(int index)
{
    double k = PromptDouble($"Enter k{index} > ");
    double b = PromptDouble($"Enter b{index} > ");
    double[] line = {k, b};
    return line;
}

void ShowPoint(string message, double[] point) {
    Console.Write($"{message} ({VisibleDouble(point[0])}, {VisibleDouble(point[1])})");
}

bool IsParallel(double[] line1, double[] line2) {
    return line1[0] == line2[0];
}

bool IsEqual(double[] line1, double[] line2) {
    return (line1[0]==line2[0]) && (line1[1]==line2[1]);
}

double[] line1  = PromptLine(1);
double[] line2  = PromptLine(2);
if (!IsParallel(line1, line2))
    {
        double[] point = IntersectionLines(line1, line2);
        ShowPoint("Intersection point : ", point);
    }
else if (IsEqual(line1, line2))
    Console.WriteLine("Upss... Lines are equal!");
else
    Console.WriteLine("Upss... Lines are parallel!");
    