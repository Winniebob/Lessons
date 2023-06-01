// Задайте двумерный массив. Напшите программу которая поменяет местами первую и последнюю строку массива.Бу

Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());



int[,] array2d = CreatMatrixInt(rows,columns);
Console.WriteLine();
PrintMatrix(array2d);
SwitchArrayFirstLastRows(array2d);
Console.WriteLine();
PrintMatrix(array2d);


int [,] CreatMatrixInt(int rows, int columns)
{
    int [,] matrix = new int [rows,columns];
    

    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = i + j;
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

void SwitchArrayFirstLastRows (int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        int tmp = matrix[0,j];
        matrix[0,j] = matrix [matrix.GetLength(1)-1,j];
        matrix [matrix.GetLength(1)-1,j] = tmp;
    }

}