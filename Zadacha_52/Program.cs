/* Запросите от пользователя размерности двумерного
массива. Напишите метод для заполнения массива
случайными числами. Напишите метод для поиска
ср. арифметического значения каждого столбца.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            if (array[i, j] >= 0)
            {
                Console.Write($" {array[i, j]}\t");
            }
            else
            {
                Console.Write(array[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array, int m)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        result = sum / m;
        Console.Write(Math.Round(result, 2) + ";  ");
    }
}

Console.Write("Введите количество строк M в двумерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов N в двумерном массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

Console.WriteLine($"\nСгенерирован следующий двумерный массив чисел:");
Array(array);

Console.Write($"\nСреднее арифметическое элементов каждого столбца в массиве: ");
Console.WriteLine();
ArithmeticMean(array, m);
