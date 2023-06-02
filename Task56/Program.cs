// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Write("введите диапозон от 1 до...");
int range = Convert.ToInt32(Console.ReadLine());
int rows = 5;
int coloumns = 4;


int[,] array2d = CreateMatrixInt(rows, coloumns);
PrintMatrix(array2d);
Console.WriteLine();
int minSumLineElements = MinSumLineElements(array2d);
Console.WriteLine($"{minSumLineElements+1} - строкa с наименьшей суммой элементов ");


int[,] CreateMatrixInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1);  j++)
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

int SumLineMatrixElements (int[,]matrix,int i)
{
    
    int sumLine = matrix[i,0];

    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i,j];
    }
    return sumLine;
}

int MinSumLineElements (int[,]matrix)
{  
    int minSumLineElements = 0;
    int sumLine = SumLineMatrixElements(matrix,0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumLine = SumLineMatrixElements(matrix,i);
        if (sumLine>tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLineElements = i;
        }
    }
    return minSumLineElements;
}

