// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


Console.WriteLine("Введите число, проверяемое в элементе массива");
int number = Convert.ToInt32(Console.ReadLine());

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

bool NumberIsMass(int[] arr, int num)
{
    
    for (int i=0; i<arr.Length; i++)
    {
    if(arr[i] == num)    
    {
        return true;
    }
    }
return false;
}
 int[] array = CreateArrayRndInt (size,min,max);
 Console.Write("[");
 PrintArray(array, ",");
Console.WriteLine("]");


bool isExistNum = NumberIsMass(array,number);
Console.WriteLine(isExistNum? "Числое есть" : "Числа нет");