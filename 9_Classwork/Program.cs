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

 // 9.2 Выяснить являются ли три числа сторонами треугольника

Console.Clear();

int A = 15;
int B = 25;
int C = 12;

bool triangle = (A + B > C && A + C > B && B + C > A);

if (triangle) System.Console.WriteLine("Из заданных отрезков можно составить треугольник");
else System.Console.WriteLine("Из заданных отрезков составить треугольник невозможно");