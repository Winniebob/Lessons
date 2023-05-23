// метод нахождения кратных чисел, проверяющий кратность одновременно к 7 и 23
Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(number); 

Console.WriteLine (result ? $"да" : "нет");
bool Multiplicity(int num)
{ 
  return  num % 7 == 0 && num % 23==0;

}