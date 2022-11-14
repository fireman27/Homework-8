// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int x = 0;
int y = 0;
int min = array[0, 0];
void MinArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }
}
MinArray(array);
Console.WriteLine("Наименьший элемент: " + min);
Console.WriteLine("Новая матрица:");
void PrintNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                if ((i == x) || (j == y))
                    continue;
                else
                    Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

PrintNewArray(array);