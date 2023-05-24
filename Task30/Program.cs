 // Напишите прогармму которая выводит массив из 8 элементов зхаполненный нулями и единицами в слчамйном порядке

 int[] arr = new int [8];

 void PrintArray(int[]array) 
 {  
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
  
 }

 void FillArray(int[] array)
 {
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = rnd.Next(0,2);
    }

 }

FillArray(arr);
Console.Write("[");
 
 
 PrintArray(arr);
 Console.Write("]");