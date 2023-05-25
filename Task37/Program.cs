// Найдите произведение пар чисел в одномернмо массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве



int [] array = CreateArrayRndInt(5,0,10);


Console.Write("[");
PrintArray(array,",");
Console.WriteLine("]");

int[] sumPairNumber = SumPairNumber(array);

Console.Write("[");
PrintArray(sumPairNumber,",");
Console.WriteLine("]");

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

int[] SumPairNumber (int []arr)
{
    int size = arr.Length/2;
    if(arr.Length % 2 == 1) size +=1;
    int[] newArr = new int [size];
    for (int i = 0; i < arr.Length/2; i++)
    {
        newArr[i] = arr[i]*arr[arr.Length-1 -i];
    }
    if(arr.Length %2 ==1) newArr[newArr.Length-1] = arr[arr.Length/2];
    return newArr;
}