// задайте двумерный массив. Найдите сумму элементов, находящихсся на главной диагонали ( с индексами (0,0); (1,1))

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int MatrixSumDiagonal(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i <matr.GetLength(0) && i <matr.GetLength(1) ; i++)
    {
        sum += matr[i,i];
    }

    return sum;
}

 int[,] array2d = CreatMatrixRndInt(3,4,1,100);
 PrintMatrix(array2d);
 int matrixSumDiagonal = MatrixSumDiagonal(array2d);
 Console.WriteLine($" Сумма элементов главной диагонали равна {matrixSumDiagonal}");