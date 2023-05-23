// Программа для передачи дней недели 3--> Среда 5-->Пятница

Console.WriteLine("Введите число дня недели");
int number1 = Convert.ToInt32(Console.ReadLine());
if ( number1 == 1)
{
    Console.WriteLine("Этот день недели, понедельник.");
}
else if ( number1 == 2) // Где else if , мы применяем для того, чтобы программа не выводила значения if + else 
{
    Console.WriteLine("Этот день недели, вторник.");
}
else if ( number1 == 3)
{
    Console.WriteLine("Этот день недели, среда.");
}
else if ( number1 == 4)
{
    Console.WriteLine("Этот день недели, четверг.");
}
else if ( number1 == 5)
{
    Console.WriteLine("Этот день недели, пятница.");
}
else if ( number1 == 6)
{
    Console.WriteLine("Этот день недели, суббота.");
}
else if ( number1 == 7)
{
    Console.WriteLine("Этот день недели, воскресенье.");
}
else
{
    Console.WriteLine("Этому числу не соответсвует день недели");
}
Console.WriteLine("Удачной недели!");