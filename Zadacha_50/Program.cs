/*Напишите программу, которая будет принимать от пользователя
позицию (M, N) двумерного массива и возвращать значение
элемента, стоящего в этой позиции. Если такой позиции
в массиве нет, то сообщить об этом пользователю.
Сгенерировать массив случайным образом.
Размерность массива определить самостоятельно.
Использование методов для заполнения массива обязательно.
Остальное можно реализовать в главной программе.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.
*/
void Element(int m, int n)
{
    int[,] array = new int[new Random().Next(2, 5), new Random().Next(2, 5)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-20, 21);
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

    if (m > array.GetLength(0) - 1 || n > array.GetLength(1) - 1)
    {
        Console.WriteLine("\nВ массиве отсутствует элемент c такой позицией.");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == m && j == n)
                {
                    Console.WriteLine($"\nЗначение элемента в позиции, введенной пользователем, равно   {array[i, j]} ");
                }
            }
        }
    }
}

Console.Write("Введите позицию элемента M в строке двумерного массива (от 0 и выше):   ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента N в столбце двумерного массива (от 0 и выше):  ");
int n = Convert.ToInt32(Console.ReadLine());

Element(m, n);
