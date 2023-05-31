//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

 int[,] array2d = CreatMatrixRndInt(rows,columns);
Console.WriteLine();
PrintMatrix(array2d);
Console.Write("Среднее арифметическое каждого столбца - >");


for (int j = 0; j < array2d.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        avarage = (avarage + array2d[i, j]);
    }
    avarage = avarage / rows;
    avarage = Math.Round(avarage,1);
    
    Console.Write(avarage + "; ");
}


 int [,] CreatMatrixRndInt(int rows, int column)
{
    int [,] matrix = new int [rows,columns];
    Random rnd = new Random ();

    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = rnd.Next(0, 10);
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
               Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine();
    }
 }



