//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите диапозон от 1 до...");
int range = Convert.ToInt32(Console.ReadLine());


int[,] array2d = CreateMatrixInt(rows, columns);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
MatrixOrderLines(array2d);
PrintMatrix(array2d);


int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(range);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}


void MatrixOrderLines(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                int tmp = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = tmp;
                }
            }

        }

    }
}
