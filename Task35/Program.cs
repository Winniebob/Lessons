// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке 10,99


Console.WriteLine("Размер массив");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в элементе массива");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в элементе массива");
int min = Convert.ToInt32(Console.ReadLine());


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

        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

int NumberQuantity (int[] arr, int min, int max)
{   
     int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=min & arr[i] <= max)
        count += 1;
       
    }
     return count;
}
int minNum = 10;
int maxNum = 99;
 int[] array = CreateArrayRndInt (size,min,max);

 Console.Write("[");
 PrintArray(array, ",");
Console.WriteLine("]");

int numberQauntity = NumberQuantity(array, minNum, maxNum);
Console.WriteLine($"Количество элементов массива в отрезке [10,99] ->{numberQauntity}");