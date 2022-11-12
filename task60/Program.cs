
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Print(Array(2, 2, 2));

int[,,] Array(int m, int n, int s)
{
    int element = 10;
    int[,,] array = new int[m, n, s];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < s; k++)
            {
                array[i, j, k] = element;
                element++;
            }
        }
    }
    return array;
}

void Print(int[,,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            for (int k = 0; k < inarray.GetLength(2); k++)

            {
                Console.Write($" {inarray[i, j, k]} ( {i}, {j}, {k})");
            }

            Console.WriteLine();
        }
    }


}