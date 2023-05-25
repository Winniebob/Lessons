// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

 Console.WriteLine("Размер массив");
int sizeMass = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в элементе массива");
int maxNumbersMass = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в элементе массива");
int minNumbersMass = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt (sizeMass,minNumbersMass,maxNumbersMass);

Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int sumOddNumbers = SumOddNumbers(array, minNumbersMass, maxNumbersMass);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях ->{sumOddNumbers}");

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

int SumOddNumbers (int[] arr, int min, int max)
{   
     int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 !=0)
        sum = arr[i] + sum;
    
    }
     return sum;
}
