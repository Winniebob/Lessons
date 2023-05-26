// Задайте массив вещественных чисел. Найдите разницу между максимальным и миниальным элементом массива.

void PrintArrayDouble(double[]arr, string sep) 
 {  
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else  Console.Write($"{arr[i]} ");
    }
  
 }

 double [] CreateArrayRndDouble(int size, int min, int max)
{
    double [] arr = new double [size];

    Random rnd = new Random ();

    for (int i=0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble()*(max - min) + min;
        arr[i] = Math.Round(num,1);
    }
    return arr;
}

double MaxArray(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max<arr[i])
        max = arr[i];
    }
    return max;
}

double MinArray(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(min>arr[i])
        min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble (5,1,10);
double maxArray = MaxArray(array);
double minArray = MinArray(array);
double differenceArray = maxArray - minArray;


Console.Write("[");
PrintArrayDouble(array, ",");
Console.WriteLine("]");

Console.WriteLine($"разницу между максимальным и миниальным элементом массива  ->{differenceArray}");