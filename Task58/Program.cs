//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("введите количество строк первой матрицы:");
int rowsMatrixOne = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк второй матрицы:");
int rowsMatrixTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов первой матрицы:");
int coloumnsMatrixOne = Convert.ToInt32(Console.ReadLine());

if (rowsMatrixTwo != coloumnsMatrixOne)
{
    Console.Write("Матрицу невозможно перемножить. Т.к количество столбцов первой матрицы != количеству строк второй");
}

Console.Write("введите количество столбцой второй матрицы:");
int coloumnsMatrixTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("введите диапозон от 1 до...");
int range = Convert.ToInt32(Console.ReadLine());



int[,] firstMatrix = CreateFirsMatrixInt(rowsMatrixOne, coloumnsMatrixOne);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);

int[,] secondMatrix = CreateSecondMatrixInt(rowsMatrixTwo, coloumnsMatrixTwo);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);

int[,] myltiplyMatrix = new int[rowsMatrixOne, coloumnsMatrixTwo];
MultiplyMatrix(firstMatrix, secondMatrix, myltiplyMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix(myltiplyMatrix);

int[,] CreateFirsMatrixInt(int rowsMatrixOne, int coloumnsMatrixOne)
{
    int[,] matrix = new int[rowsMatrixOne, coloumnsMatrixOne];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(range);

        }
    }
    return matrix;
}

int[,] CreateSecondMatrixInt(int rowsMatrixTwo, int coloumnsMatrixTwo)
{
    int[,] matrix = new int[rowsMatrixTwo, coloumnsMatrixTwo];

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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] myltiplyMatrix)
{
    for (int i = 0; i < myltiplyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myltiplyMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < myltiplyMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
                myltiplyMatrix[i, j] = sum;
            }

        }
    }
}
