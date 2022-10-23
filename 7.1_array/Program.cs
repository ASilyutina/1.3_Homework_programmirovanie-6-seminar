// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetTableDouble(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().NextDouble() * 100;
        }
    }
    return table;
}

void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + "    ");
        }
        System.Console.WriteLine();
    }
}

int m = 4;
int n = 3;
double[,] TableDouble = GetTableDouble(m, n);
PrintTable(TableDouble);