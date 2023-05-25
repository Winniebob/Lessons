// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве. 

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

int minNum = 100;
int maxNum = 1000;
int[] array = CreateArrayRndInt (size,minNum,maxNum);

Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int eventNumbers = EvenNumbers(array, 100, 1000);
Console.WriteLine($"Количество четных элементов в массиве ->{eventNumbers}");

  
  void PrintArray(int[]arr, string sep) 
 {  
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else  Console.Write($"{arr[i]} ");
    }
  
 }


 int [] CreateArrayRndInt(int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random ();

    for (int i=0; i < arr.Length; i++)
    {

        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int EvenNumbers (int[] arr, int min, int max)
{   
     int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        count += 1;
       
    }
     return count;
}



