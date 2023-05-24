﻿// Напишите программу которая задает массив из 8 элементов и выводит их на экран

 
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

void PrintArray(int[] arr, string sep)
{
     for (int i=0; i<arr.Length; i++)
     {
        if (i<arr.Length-1) Console.Write($"{arr[i]}{sep}");
     }
}

int[] array = CreateArrayRndInt(8, 2, 32);
Console.Write("[");
PrintArray(array, ",");
Console.Write("]");