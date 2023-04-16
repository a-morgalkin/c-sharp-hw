int PromptInt(string message)
{
Console.Write(message);
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
return result;
}

void WriteError(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();    
}

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int GetYfromXYZ(int xyz)
{
    return (xyz % 100) / 10;
}

int number;
int digit;
Console.Write("Enter a three-digit number> ");
string input = Console.ReadLine();
if (int.TryParse(input, out number) && number >= 100 && number < 1000)
    Console.WriteLine($"Second digit is {GetYfromXYZ(number)}");
else 
    WriteError("It's not a number or three-digit number");

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetThirdDigit(int number)
{
int result = -1;
number = Math.Abs(number);
if (number > 99)
    {
    while (number > 999)
        number = number / 10;
    result = number % 10;
    }
return result;
}

int number = PromptInt("Enter a number > ");
int digit = GetThirdDigit(number);
if (digit > -1)
    Console.WriteLine($"Third digit is: {digit}");
else
    WriteError("третьей цифры нет");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
bool IsWeekEnd(int dayOfWeek)
{
    return (dayOfWeek == 7) | (dayOfWeek == 6);
}

int inputDay = PromptInt("Input a day number > ");
if (IsWeekEnd(inputDay))
    Console.WriteLine("Congratulations, it's weekend day");
else
    Console.WriteLine("it's not a weekend :()");
*/