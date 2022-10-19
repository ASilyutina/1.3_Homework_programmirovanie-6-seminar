// Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

int[,] GetNewCords(int[] a, int[] b, int[] c, int[] d, int k)       // пересчитываем координаты (умножаем на коэффициент), кроме координат точки А (левый нижний угол), эта точка не смещается
{
    int[,] coor = new int[4, 2];                                    // для вывода всех координат записываем их в двумерный массив
    for (int ii = 0; ii < 2; ii++)                                  // индекс массива - координаты точки
    {
        for (int j = 0; j < 2; j++)                                 // индекс столбцов, индексы строк задаем ниже вручную,
        {
            if (ii == j)                                            // индекс столбца равен индексу координаты точки
            {
                coor[0, j] = a[ii];                                 // здесь задаем новые координаты с поправкой на неподвижную точку А
                coor[1, j] = (b[ii] - a[ii]) * k + a[ii];
                coor[2, j] = (c[ii] - a[ii]) * k + a[ii];
                coor[3, j] = (d[ii] - a[ii]) * k + a[ii];
            }
        }
    }
    return coor;
}

void PrintCords(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write($"({arr[i, j]}, ");
            else System.Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 4;                                                          // коэффициент масштабирования
int[] pointA = { 1, 1 };                                            // координаты точек
int[] pointB = { 2, 3 };
int[] pointC = { 5, 3 };
int[] pointD = { 4, 1 };
char[] pointName = { 'A', 'B', 'C', 'D' };

System.Console.WriteLine();
int[,] newCords = GetNewCords(pointA, pointB, pointC, pointD, k);
PrintCords(newCords, pointName);

