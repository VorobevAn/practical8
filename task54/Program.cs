

// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = Array(4, 5);
Print(arr);
Console.WriteLine();
int[,] ar = NewArrey(arr);
Print(ar);

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
int[,] NewArrey(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int count = 0; count < ar.GetLength(1); count++)
        {

            int temp = 0;


            for (int j = 1; j < ar.GetLength(1) - count; j++)
            {
                if (ar[i, j - 1] < ar[i, j])
                {
                    temp = ar[i, j];
                    ar[i, j] = ar[i, j - 1];
                    ar[i, j - 1] = temp;
                }


            }


        }
    }
    return ar;
}