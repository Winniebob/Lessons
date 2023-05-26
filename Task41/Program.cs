//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArrayInt(size);
Console.Write("[");
PrintArray(array,",");
Console.WriteLine("]");

int numbersMoreZero = NumbersMoreZero(array);
Console.WriteLine($"Цифр в массиве > 0 -> {numbersMoreZero}");

 
  void PrintArray(int[]arr, string sep) 
 {  
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else  Console.Write($"{arr[i]} ");
    }
  
 }

 int [] CreateArrayInt(int size)
{
    int [] array = new int [size];
    

    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"Введите  {size} цифр ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        array[i] =  numbers;
    }
    return array;
}

int NumbersMoreZero (int [] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count++;
    }
    return count;
}