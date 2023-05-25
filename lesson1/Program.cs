
// Инициализация для строк с помощью константы String.Empty 
//Индексы меняются от нуля table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]

/*string[,]table = new string[2,5];
table [1, 2] = "слово";

for (int rows = 0; rows < 2; rows++) // две строки
{
    for (int columns = 0; columns < 5; columns++) // пять столбцов во внутренним цикле
    {
        Console.WriteLine($"{table[rows,columns]} --");
    }
}*/

// int [,] matrix = new int[3,4]; // задаем двумерный массив целочисленный

int [,] matrix = new int[3,4];
PrintArray(matrix); //Инициализация убеждаясь, что у нас 0ли
FillArray(matrix);  //Вводим метод FillArray
Console.WriteLine(); // Создает прослойку между 0 и массивом
PrintArray(matrix);

void FillArray(int[,]matr) // метод Объявление псевдослучайных чисел в таблицу матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);  // само объявление где Next (1,10) является как полуинтервал
        }
    }
}

void PrintArray(int[,]matr) // В качестве аргумента метод принт аррей принимает двумерный массив и печатает его на экране.
{     
for (int i = 0; i < matr.GetLength(0) ; i++) // где  matrix.GetLength(0) это функционал указывающий на массив, где 0 это количество строк. У нас количество  строк будет 3.
    {   
    for (int j = 0; j < matr.GetLength(1);j++) // где  matrix.GetLength(1) это функционал для указание количества столбцов массива, у нас их 4.
        {
        System.Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine(); // Ввели Write в цикле for для того, чтобы курсор не съезжал вниз. После метода ввели пробел с помощью WriteLine
    }
}
