// Задача 57 Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());



int[,] array2d = CreatMatrixInt(rows,columns);
Console.WriteLine();
PrintMatrix(array2d);
int[] array = MatrixToArray(array2d);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
Dictionary(array);



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


int[] MatrixToArray (int[,] matrix)
{
    int []  arr = new int [matrix.Length];
    int k = 0; // Новый счетчик.

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i,j];
            k++;

        }
    }
    return arr;

}

  void PrintArray(int[]arr) 
 {  
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length - 1) Console.Write($"{arr[i]} ");
        else  Console.Write($"{arr[i]} ");
    }
  
 }

 void Dictionary (int[] arr)
 {
    int currentNum = arr[0]; // начинаем с первого элемента массива.
    int count = 1; // счетчик, один так как один уже взяли.
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == currentNum) count ++;
        else 
        {
            Console.WriteLine($"{currentNum} встречается - > {count} раз");
            count = 1;
            currentNum = arr[i];
        }
       
    }
      Console.WriteLine($"{currentNum} встречается - > {count} раз");
 }