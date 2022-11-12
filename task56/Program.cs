

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка


int[,] arr = Array(4, 5);
Print(arr);
MinSumm(arr);


int[,] Array(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write("{0,2}", inarray[i, j]);
        }
        Console.WriteLine();
    }

}

void MinSumm(int[,] arrey)
{
    int line = 0;
    int min = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        int summ = 0;

        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            summ += arrey[i, j];
        }
      //  Console.WriteLine(summ);
        if (i == 0)
        {
            min = summ;
        }
        else if (summ < min)
        {
            min = summ;
            line = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {line + 1}");

}
