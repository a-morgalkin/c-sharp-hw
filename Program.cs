int PromptInt(string message)
{
Console.Write(message);
string input = Console.ReadLine();
int result = Convert.ToInt32(input);
return result;
}

void PrintArray(int[,] array, int colWide = 8)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(Convert.ToString(array[i,j]).PadLeft(colWide));
        Console.WriteLine();
    }
}

int[,] CreateArray(int lines, int columns, int maxValue, bool unique = false)
{
    int[,] array = new int[lines, columns];
    HashSet<int> numbersSet = new HashSet<int>();
    int tempRand;
    for(int i = 0; i<lines; i++)
        for(int j = 0; j<columns; j++)
        {
            if (unique)
                while (array[i,j] == 0)
                    {
                        tempRand = new Random().Next(maxValue+1);
                        if (numbersSet.Add(tempRand))
                            array[i,j] = tempRand;
                    }
            else
                array[i,j] = new Random().Next(maxValue+1);
        }
    return array;
}

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void QuickBackSortRaw(int[,] array, int raw, int start, int end)
{
    if (end <= start) return;
    int pivot = PartitionBack(array, raw, start, end); //sort and define pivot
    QuickBackSortRaw(array, raw, 0, pivot - 1); //sort left partition
    QuickBackSortRaw(array, raw, pivot + 1, end); //sort right partition

}

int PartitionBack(int[,] array, int raw, int start, int end)
{
    int pivot = array[raw, end];
    int i = start - 1;
    int temp;
    for (int j = start; j <= end - 1; j++) {
        if (array[raw, j] > pivot) {
            i++;
            temp = array[raw, i];
            array[raw, i] = array[raw, j];
            array[raw, j] = temp;
        }
    }
    i++;
    temp = array[raw, i];
    array[raw, i] = array[raw, end];
    array[raw, end] = temp;

    return i;
}
void SortBackArrayRows(int [,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
        QuickBackSortRaw(array, m, 0, array.GetLength(1)-1);
}

Console.WriteLine("--- Задача 54 ---");
int[,] array54 = CreateArray(5, 5, 9);
PrintArray(array54);
SortBackArrayRows(array54);
Console.WriteLine();
PrintArray(array54);

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultArray (int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
    {
        Console.WriteLine("Матрицы несогласованы");
        return new int[0,0];
    }
    int[,] c = new int[a.GetLength(0), b.GetLength(1)]; 
    for(int m = 0; m < c.GetLength(0); m++)
        for(int n = 0; n < c.GetLength(1); n++)
        {
            int sum = 0;
            for(int i = 0; i < a.GetLength(1); i++)
                sum += a[m,i] * b[i,n];
            c[m,n] = sum;
        }
    return c;
}

Console.WriteLine("--- Задача 58 ---");
int[,] array58a = {{2,4},{3,2}};
int[,] array58b = {{3,4},{3,3}};
// int[,] array58b = {{1,2,2},{3,1,1}};
// int[,] array58a = {{4,2},{3,1},{1,5}};

int[,] array58c = MultArray(array58a, array58b);
PrintArray(array58c);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Print3dArray(int[,,] array, int colWide = 8)
{
    for(int i = 0; i<array.GetLength(0); i++) 
    {
        Console.WriteLine($"Слой {i} :");
        for(int j=0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(Convert.ToString(array[i,j,k]).PadLeft(colWide));
            Console.WriteLine();
        }
    }
}

int[,,] Create3dArray(int x, int y, int z, int maxValue, bool unique = false)
{
    int[,,] array = new int[x, y, z];
    HashSet<int> numbersSet = new HashSet<int>();
    var rand = new Random();
    int tempRand;
    unique = unique && maxValue >= x * y * z; // отменяем уникальность если maxValue меньше количества ячеек
    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++)
            {
                if (unique)
                    while (array[i,j,k] == 0)
                        {
                            tempRand = rand.Next(maxValue+1);
                            if (numbersSet.Add(tempRand))
                                array[i,j,k] = tempRand;
                        }
                else
                    array[i,j,k] = rand.Next(maxValue+1);
            }
    return array;
}

int[,,] array60 = Create3dArray(2, 2, 2, 8, true); // отстутсвие дублей проверим на maxValue 8
Console.WriteLine("--- Задача 60 ---");
Print3dArray(array60);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int GetNextPos(int[,] array, int[] pos, int dir)
{
    int maxY = array.GetLength(0);
    int maxX = array.GetLength(1);
    int count = 0;
    while (++count < 3) // делаем не больше двух проходов - одного поворота
    {
        if (dir == 0 && pos[1]+1 < maxX && array[pos[0],pos[1]+1] == 0) 
        {
            pos[1]++;
            return dir;
        }
        if (dir == 1 && pos[0]+1 < maxY && array[pos[0]+1,pos[1]] == 0)
        {
            pos[0]++;
            return dir;
        }
        if (dir == 2 && pos[1]-1 >= 0 && array[pos[0],pos[1]-1] == 0)
        {
            pos[1]--;
            return dir;
        }
        if (dir == 3 && pos[0]-1 >= 0 && array[pos[0]-1,pos[1]] == 0)
        {
            pos[0]--;
            return dir;
        }
        dir++;
        if ( dir > 3 ) dir = 0;
    }
    return dir;
}

void FillSnailArray(int[,] array)
{
    int[] curPos = {0, 0};
    int cellsQty = array.GetLength(0) * array.GetLength(1);
    int dir = 0; // 0 - right, 1 - down, 2- left, 3 - up
    for (int i = 1; i <= cellsQty; i++)
    {
        array[curPos[0], curPos[1]] = i;
        dir = GetNextPos(array, curPos, dir);
    }
}

int[,] array62 = new int[4, 4];
FillSnailArray(array62);
Console.WriteLine("--- Задача 62 ---");
PrintArray(array62);
