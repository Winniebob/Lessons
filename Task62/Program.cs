// Заполните спирально массив 4 на 4. 


int rowsSpiral = 4;
int coloumnsSpiral = 4;

int[,] spriralMatrix = CreateMatrixInt(4,4);
SpiralMatrix(spriralMatrix);
PrintMatrix(spriralMatrix);

int[,] CreateMatrixInt(int rowsSpiral, int coloumnsSpiral)
{
    int[,] matrix = new int[rowsSpiral, coloumnsSpiral];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);

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
           
            Console.Write($" {matrix[i, j],5} ");
           
        }
        Console.WriteLine();
    }
}

void SpiralMatrix (int[,] matrix )
{
    int temp = 1;
    int i = 0;
    int j = 0 ;
    while ( temp <= matrix.GetLength(0) * matrix.GetLength(1) )
    {
        matrix[i,j] = temp;
        temp++;
        if ( i <= j+ 1 && i + j < matrix.GetLength(1)-1)
        j++;
        else if (i<j && i + j >= matrix.GetLength(0)-1)
        i++;
        else if (i>= j && i + j>matrix.GetLength(1)-1)
        j--;
        else i--;
    }
}