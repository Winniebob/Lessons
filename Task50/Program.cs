//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите строку искомого элемента двумерного массива");
int rowsSeach = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столб искомого элемента двумерного массива");
int columsSeach = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreatMatrixRnddouble(3, 4, -100, 100);
PrdoubleMatrix(array2d);

bool seachElementArray = SeachElementArray(array2d, rowsSeach, columsSeach);
Console.Write(seachElementArray ? $"Значение элемента равно {array2d[rowsSeach - 1, columsSeach - 1]}" : $"{rowsSeach},{columsSeach} -> Такого элемента нет в массиве  ");


double[,] CreatMatrixRnddouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }

    }
    return matrix;
}


void PrdoubleMatrix(double[,] matrix)
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

bool SeachElementArray(double[,] matrix, int rowsSeach, int columsSeach)
{
    if(rowsSeach < 0 || columsSeach < 0)
    return false;
    else if (rowsSeach <= matrix.GetLength(0) + 1 && columsSeach <= matrix.GetLength(1) + 1)
    return true;
    else return false;
  

}

