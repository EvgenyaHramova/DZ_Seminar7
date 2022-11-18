/* Запросите от пользователя размерности двумерного массива.
Напишите метод для заполнения массива случайными  вещественными числами.
Напишите метод для вывода массива на экран
(постарайтесь вывести массив красиво). Округлите значения,
генерируемые Random до двух знаков после запятой.
m = 3, n = 4.

0,5  7  -2  -0,2
1  -3,3  8  -9,9
8  7,8 -7,1  9
*/
void NewArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round((new Random().Next(-20, 21) + new Random().NextDouble()), 2);
            if (array[i, j] > 0)
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

Console.Write("Ведите количество строк M в двумерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите количество столбцов N в двумерном массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nСгенерирован следующий двумерный массив вещественных чисел:");
NewArray(m, n);
