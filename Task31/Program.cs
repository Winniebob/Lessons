// Задайте массив из 12 элементов заполненный случайными числами из промежутка от [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.



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

/*int [] GetSumPositiveNegativeElem(int[] arr)
{

    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }
        
    }
    return  new int[]{sumPositive,sumNegative};
}*/

int SumPositive (int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) sum += arr[i];
    }
    return sum;
    
}

int SumNegative (int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<0) sum += arr[i];
    }
    return sum;
    
}

 int[] array = CreateArrayRndInt (12,-9,9);
 Console.Write("[");
 PrintArray(array, ",");
Console.WriteLine("]");

//int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
int sumNegative =  SumNegative(array);
int sumPositive =  SumPositive(array);
//Console.WriteLine($"Сумма положительных элементов равна {sumPositiveNegativeElem[0]}");
//Console.WriteLine($"Сумма положительных элементов равна {sumPositiveNegativeElem[1]}");
Console.WriteLine($"Сумма положительных элементов равна {sumNegative}");
Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");