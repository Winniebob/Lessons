Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
   if (number1 == number2 * number2) // Выражение опредления является ли первое число квадартом второго числа, путем перемножения второго числа самого на себя. (Приравнивает)
        {
         Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
        }
    else 
    {
       Console.WriteLine ($"Первое число {number1} не является квадратом второго числа {number2}");
    }
Console.WriteLine ("Спасибо за внимание");