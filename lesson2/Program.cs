﻿/*
int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

PrintImage(pic); // В качестве аргумента передаем массив который содержит в себе картинку.
FillImage(13,13); // указание случайной точки
PrintImage(pic);
void PrintImage(int[,]image) // В качестве аргумента метод принт аррей принимает двумерный массив и печатает его на экране.
{     
for (int i = 0; i < image.GetLength(0) ; i++) // где  image.GetLength(0) это функционал указывающий на массив, где 0 это количество строк. У нас количество  строк будет 3.
    {   
    for (int j = 0; j < image.GetLength(1);j++) // где  image.GetLength(1) это функционал для указание количества столбцов массива, у нас их 4.
        {
       // System.Console.Write($"{image[i,j]} ");
       if(image[i,j]== 0) Console.Write($" "); // говорит о том, что в случае если в массиве есть ноль мы будем печатать пробел.
       else Console.Write($"+");
        }
    Console.WriteLine(); // Ввели Write в цикле for для того, чтобы курсор не съезжал вниз. После метода ввели пробел с помощью WriteLine
    }
}

void FillImage ( int row, int col) // в качестве аргументов указана позиция строки и пикселя с которого начнется закраска
{
    if (pic[row,col]==0) // == нуль говорит о том, что пиксель не закрашен
    {
        pic[row,col] = 1; // красим пиксель единицой
        FillImage (row-1,col);
        FillImage (row,col-1); //метод вызывает сам себя передвигаясь по столбцам и строчкам
        FillImage (row+1,col);
        FillImage (row,col+1);
    }
} */







/*int Factorial (int n) // метод возвращающий инт который принимает другое целое число
{
    //1! =1   , что условно значит,если мы дошли до единицы, то возвращаем единицу (0! =1 это тоже единица)
    if (n==1) return 1; // обязательно возвращай значения !
    else return n * Factorial(n-1); // в противном случае нужно взять текущие значение и умножить на факториал предыдущего числа тоесть n-1
}
for (int i = 1; i < 40; i++) // вызовет переполнение типа
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // показывает что число 17 уже не вмещается
} */
// Console.WriteLine(Factorial(5)); // где фактариал трех это 1*2*3 =6








/*
double Factorial (double n) // Double помогает справится с переполнением типа данных.
{
    
    if (n==1) return 1; 
    else return n * Factorial(n-1); 
}
for (double i = 1; i < 40; i++) 
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); 
}*/



// f(1) =1
// f(2) =1
// f(n) = f(n-1) + f(n-2)  Определение чисел фибаначи

double Fibonacci (double n) // именуем в качестве аргумента н
{
    if (n==1||n==2) return 1; // если зачен н=1 или н=2 возвращаем 1
    else return Fibonacci(n-1)+ Fibonacci(n-2); // в противном случае возвращаем  ПИШИ RETURN
}

for (double i = 1; i < 50; i++)
{
   // Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"f{i} = {Fibonacci(i)}"); 
}

