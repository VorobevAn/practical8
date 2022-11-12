

// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц,
// там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] arr = Array(2, 2);
Print(arr);
Console.WriteLine();
int[,] arr2 = Array(2, 2);
Print(arr2);
int[,] result = Result(arr, arr2);
Console.WriteLine("Результат:");
Print(result);

int[,] Array(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
    return array;
}

int[,] Result(int[,] arr, int[,] arr2)
{
    int[,] result = new int[arr.GetLength(0), arr2.GetLength(1)];


    for (int i = 0; i < arr.GetLength(0); i++)

    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {

            for (int k = 0; k < arr.GetLength(1); k++)
            {
                result[i, j] += (arr[i, k] * arr2[k, j]);
            }

        }
    }
    return result;
}

void Print(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write("{0,3}", inarray[i, j]);
        }
        Console.WriteLine();
    }

}