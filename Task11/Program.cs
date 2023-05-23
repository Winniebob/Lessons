// Напишите программу которая будет выводить случайное трехзначеное число и удаляет вторую цифру этого числа. 456 ->46
int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число -> {number} ");
int twoDigit = TwoDigit(number);
Console.WriteLine($" первая и третья цифра из трех значного числа {number}->{twoDigit} ");

int TwoDigit (int num)
{
    int firstDigit = num/100;
    int threeDigit = num%10;
    int twoDigit = firstDigit * 10 + threeDigit; // Умножаем на 10, чтобы получить число с 0 для сложение с третьим числом.
    return twoDigit;
  
}