int PromptInt(string message)
{
Console.Write(message);
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
return result;
}

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
int ReverseNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
    return result;
}

bool IsPalindrom(int number)
{
    return number == ReverseNumber(number);
}

int number = PromptInt("input a number > ");
Console.WriteLine(IsPalindrom(number)?"Fantastic! It's a palindrom number":"Ups... It's not a palindrom number");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double GetDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)));
}

double PromptDouble(string message)
{
Console.Write(message);
string input = Console.ReadLine();
return Convert.ToDouble(input);
}

double x1 = PromptDouble("Input A(x) > ");
double y1 = PromptDouble("Input A(y) > ");
double z1 = PromptDouble("Input A(z) > ");
double x2 = PromptDouble("Input B(x) > ");
double y2 = PromptDouble("Input B(y) > ");
double z2 = PromptDouble("Input B(z) > ");

Console.WriteLine($"The distance between A and B is: {Math.Round(GetDistance3D(x1,y1,z1,x2,y2,z2), 2)}");
*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintPowerTable(int number, int power)
{
    int i=1;
    while (i <= number)
    {
        Console.WriteLine($"{i} ^ {power} = {Math.Pow(i, power)}");
        i++;
    }
}
int num = PromptInt("Enter a N > ");
PrintPowerTable(num, 3);