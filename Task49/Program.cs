 int [,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows,columns];
    Random rnd = new Random ();

    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = rnd.Next(min, max+1);
        }

    }
    return matrix;
}


  void PrintMatrix(int[,]matrix) 
 {  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
               Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine();
    }
 }

 int [,] MatrixQuarty (int [,]matr)
 {
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {   
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i,j] *= matr[i,j];
        }
        
    }
    return matr;
 }

  int[,] array2d = CreatMatrixRndInt(3,4,-100,100);
 PrintMatrix(array2d);
 MatrixQuarty(array2d);
Console.WriteLine(" Массив с квадратами элементов с четными индексами:");
 PrintMatrix(array2d);