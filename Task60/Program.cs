//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2
Console.WriteLine($"Введите размер массива X x Y x Z:");
Console.WriteLine("введите количество строк");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк");
int z = Convert.ToInt32(Console.ReadLine());



int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);



void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] tempArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < tempArray.GetLength(0); i++)
  {
    tempArray[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (tempArray[i] == tempArray[j])
        {
          tempArray[i] = new Random().Next(10, 100);
          j = 0;
          number = tempArray[i];
        }
          number = tempArray[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}