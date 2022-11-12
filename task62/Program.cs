
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4, 4];
Array(array);
Print(array);

void Array(int[,] arr)
{
    int element = 1;
    int i = 0;
    int j = 0;
    for (int k = 0; k < arr.GetLength(0); k++)
    {

        for (j = k; j < arr.GetLength(1) - k; j++)
        {
            arr[i, j] = element;
            element++;
        }
        j--;
        for (i++; i < arr.GetLength(1) - k; i++)
        {
            arr[i, j] = element;
            element++;
        }
        i--;
        for (j--; j >= k; j--)
        {
            arr[i, j] = element;
            element++;
        }
        j++;
        for (i--; i >= k + 1; i--)
        {
            arr[i, j] = element;
            element++;
        }
        i++;
    }
}

void Print(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write("{0,4}", inarray[i, j]);
        }
        Console.WriteLine();
    }
}