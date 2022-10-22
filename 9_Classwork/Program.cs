//  9.1. Написать программу преобразования десятичного числа в двоичное

/*Console.Clear();

System.Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);

int[] ConvertToBinary(int num)
{
    int num2 = num;
    int size = 0;
    while (num > 0)
    {
        num = num / 2;
        size++;
    }

    int[] binary = new int[size];
    for (int i = size - 1; i >= 0; i--)
    {
        binary[i] = num2 % 2;
        num2 = num2 / 2;
    }
    return binary;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
    }
}

PrintArray(ConvertToBinary(number));
*/

 /*// 9.2 Выяснить являются ли три числа сторонами треугольника

Console.Clear();

int A = 15;
int B = 25;
int C = 12;

bool triangle = (A + B > C && A + C > B && B + C > A);

if (triangle) System.Console.WriteLine("Из заданных отрезков можно составить треугольник");
else System.Console.WriteLine("Из заданных отрезков составить треугольник невозможно");

*/

//9.3 В двумерном массиве n×k заменить четные элементы на противоположные
/*
int[,] GetTable(int row, int col, int min, int max)
{
    int[,] firstTab = new int[row, col];
    for (int i = 0; i < firstTab.GetLength(0); i++)
    {
        for (int j = 0; j < firstTab.GetLength(1); j++)
        {
            firstTab[i, j] = new Random().Next(min, max + 1);
        }
    }
    return firstTab;
}

int[,] ReplaceEvenToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = array[i, j] * (-1);
        }
    }
    return array;
}

void PrintTable(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int row = 5;
int col = 10;
int min = 1;
int max = 10;

int[,] firstArray = GetTable(row, col, min, max);
PrintTable(firstArray);
System.Console.WriteLine("-------------");
int[,] replaceArray = ReplaceEvenToSquare(firstArray);
PrintTable(replaceArray);
*/

//9.4 В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.Clear();
System.Console.WriteLine();

int[,] CreateArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[] FindNumberPosition(int[,] arr, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 1000 > 0) System.Console.Write($"{array[i, j]}   ");
            else if (array[i, j] / 100 > 0) System.Console.Write($" {array[i, j]}   ");
            else if (array[i, j] / 10 > 0) System.Console.Write($"  {array[i, j]}   ");
            else System.Console.Write($"   {array[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}

void PrintPosition(int[] pos, int num)
{
    System.Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0) System.Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    else System.Console.WriteLine($"Число {num} отсутствует в заданном массиве");
    System.Console.WriteLine();
}

int GetNumerToFind()
{
    System.Console.WriteLine();
    System.Console.Write("Введите число:   ");
    string writeNumber = Console.ReadLine();
    int number = Convert.ToInt32(writeNumber);
    return number;
}

int row = 7;
int col = 10;
int min = 1;
int max = 1000;

int[,] array1 = CreateArray(row, col, min, max);
PrintArray(array1);
int number = GetNumerToFind();
int[] position = FindNumberPosition(array1, number);
PrintPosition(position, number);